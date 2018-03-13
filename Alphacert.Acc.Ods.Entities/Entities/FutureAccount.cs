using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class FutureAccount
    {
        public int FutureAccountId { get; set; }
        public string CustomAccount { get; set; }
        public int? FundingAccountId { get; set; }
        public int PortfolioId { get; set; }
        public bool? Inactive { get; set; }

        public FundingAccounts FundingAccount { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
