using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class FundingAccountPortfolioBenchmark
    {
        public int FundingAccountPortfolioBenchmarkId { get; set; }
        public int FundingAccountId { get; set; }
        public int PortfolioComponentId { get; set; }
        public decimal Value { get; set; }
        public DateTime EffectiveDate { get; set; }
        public bool? Inactive { get; set; }

        public FundingAccounts FundingAccount { get; set; }
        public PortfolioComponent PortfolioComponent { get; set; }
    }
}
