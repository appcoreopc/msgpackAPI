using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alphacert.Acc.Ods.Api.Models
{
    public class ViewValuation
    {
        public string InstrumentId { get; set; }
        public string FundKey { get; set; }
        public string PortfolioId { get; set; }
        public decimal? GrossMarketValueBase { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}
