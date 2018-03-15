using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alphacert.Acc.Ods.Api.Models
{
    [MessagePackObject]
    public class ViewValuation
    {
        [Key(0)]
        public string InstrumentId { get; set; }
        [Key(1)]
        public string FundKey { get; set; }
        [Key(2)]
        public string PortfolioId { get; set; }
        [Key(3)]
        public decimal? GrossMarketValueBase { get; set; }
        [Key(4)]
        public DateTime ModifiedAt { get; set; }

    }
}
