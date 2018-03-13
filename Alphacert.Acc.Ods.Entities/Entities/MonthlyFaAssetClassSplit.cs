using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class MonthlyFaAssetClassSplit
    {
        public int MonthlyFaAssetClassSplitId { get; set; }
        public DateTime ValuationDate { get; set; }
        public int FundingAccountId { get; set; }
        public int AssetClassId { get; set; }
        public decimal MarketValue { get; set; }
        public bool? Inactive { get; set; }
        public DateTime WhenCreated { get; set; }

        public AssetClass AssetClass { get; set; }
        public FundingAccounts FundingAccount { get; set; }
    }
}
