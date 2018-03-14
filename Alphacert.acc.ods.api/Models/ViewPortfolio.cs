using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alphacert.Acc.Ods.Api.Models
{
    public class ViewPortfolio
    {
        public string PortfolioId { get; set; }
        public string FundKey { get; set; }
        public string PortfolioName { get; set; }
        public string StrategyCode { get; set; }
        public DateTime ModifiedAt { get; set; }
    }

}
