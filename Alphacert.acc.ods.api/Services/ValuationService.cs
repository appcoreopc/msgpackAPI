using Alphacert.Acc.Ods.Api.Models;
using Alphacert.Acc.Ods.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Alphacert.Acc.Ods.Api.Services
{
    public class ValuationService : IValuationService
    {
        private readonly string _connectionString = string.Empty;
        public ValuationService(string conn) => _connectionString = conn;
      
        public void GetValuationData()
        {
            var path = Path.Combine(AppConstant.fileResourceFolder, AppConstant.fileResourceName);
            if (!File.Exists(path))
            {

                Task.Run(() =>
                {
                    var optionsBuilder = new DbContextOptionsBuilder<IDS_ODSContext>();
                    optionsBuilder.UseSqlServer(_connectionString);

                    using (var context = new IDS_ODSContext(optionsBuilder.Options))
                    {
                        var list = context.VwValuations.Take(100).ToList();

                        var data = list.Select(a => new ViewValuation
                        {
                            InstrumentId = a.InstrumentId.ToString(),
                            GrossMarketValueBase = a.Market_Value_Local_Discount,
                            PortfolioId = a.PortfolioId.ToString()
                        });

                        string json = JsonConvert.SerializeObject(data.ToArray());
                        var fileTargetPath = Path.Combine(AppConstant.fileResourceFolder, AppConstant.fileResourceName);
                         File.WriteAllText(fileTargetPath, json);
                    }
                });
            }
        }
    }
}
