using Alphacert.Acc.Ods.Api.Models;
using Alphacert.Acc.Ods.Entities.Entities;
using MessagePack;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Alphacert.Acc.Ods.Api.Services
{
    public class MsgPackValuationService : IValuationService
    {
        private readonly string _connectionString = string.Empty;
        private const int TakeAmount = 100;

        public MsgPackValuationService(string connectionString) => _connectionString = connectionString;
                
        /// <summary>
        /// Serialized data of type IEnumerable<ViewValuation> into a stream.
        /// </summary>
        public void GetValuationData()
        {
            var path = Path.Combine(AppConstant.fileResourceFolder, AppConstant.fileResourceMsgPackName);
           
            if (!File.Exists(path))
            {
                Task.Run(() =>
                {
                    var optionsBuilder = new DbContextOptionsBuilder<IDS_ODSContext>();
                    optionsBuilder.UseSqlServer(_connectionString);

                    using (var context = new IDS_ODSContext(optionsBuilder.Options))
                    {
                        var list = context.VwValuations.Take(TakeAmount).ToList();

                        var data = list.Select(a => new ViewValuation
                        {
                            InstrumentId = a.InstrumentId.ToString(),
                            GrossMarketValueBase = a.Total_Market_Value_Base_Discount,
                            PortfolioId = a.PortfolioId.ToString()
                        });

                        var fileStream = System.IO.File.OpenWrite(path);
                        MessagePackSerializer.Serialize(fileStream, data);
                        
                        fileStream.Flush();
                        fileStream.Close();
                    }
                });
            }
        }
    }
}
