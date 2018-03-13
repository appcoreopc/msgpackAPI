using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class PortfolioComponent
    {
        public PortfolioComponent()
        {
            FundingAccountPortfolioBenchmark = new HashSet<FundingAccountPortfolioBenchmark>();
        }

        public int PortfolioComponentId { get; set; }
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public bool? Inactive { get; set; }

        public Portfolio Portfolio { get; set; }
        public ICollection<FundingAccountPortfolioBenchmark> FundingAccountPortfolioBenchmark { get; set; }
    }
}
