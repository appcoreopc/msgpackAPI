using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class FundingAccountAssetClassBenchmark
    {
        public int AccountAssetClassBenchmarkId { get; set; }
        public int FundingAccountId { get; set; }
        public int AssetClassId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal Value { get; set; }
        public bool? Inactive { get; set; }

        public AssetClass AssetClass { get; set; }
        public FundingAccounts FundingAccount { get; set; }
    }
}
