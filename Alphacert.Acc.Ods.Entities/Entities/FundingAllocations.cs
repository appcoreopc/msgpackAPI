using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class FundingAllocations
    {
        public int TradeId { get; set; }
        public int FundingAccountId { get; set; }
        public decimal AllocationAmount { get; set; }
        public string Unit { get; set; }
        public bool? Inactive { get; set; }

        public FundingAccounts FundingAccount { get; set; }
        public Trade Trade { get; set; }
    }
}
