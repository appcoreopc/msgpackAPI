using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class FundingAccounts
    {
        public FundingAccounts()
        {
            FundingAccountAssetClassBenchmark = new HashSet<FundingAccountAssetClassBenchmark>();
            FundingAccountAssetClassSplit = new HashSet<FundingAccountAssetClassSplit>();
            FundingAccountPortfolioBenchmark = new HashSet<FundingAccountPortfolioBenchmark>();
            FundingAllocations = new HashSet<FundingAllocations>();
            FutureAccount = new HashSet<FutureAccount>();
            MonthlyFaAssetClassSplit = new HashSet<MonthlyFaAssetClassSplit>();
            TotalEquityWeightReported = new HashSet<TotalEquityWeightReported>();
            TotalEquityWeightTestHistory = new HashSet<TotalEquityWeightTestHistory>();
        }

        public int FundingAccountId { get; set; }
        public string FundingAccountName { get; set; }
        public string FundingAccountCode { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<FundingAccountAssetClassBenchmark> FundingAccountAssetClassBenchmark { get; set; }
        public ICollection<FundingAccountAssetClassSplit> FundingAccountAssetClassSplit { get; set; }
        public ICollection<FundingAccountPortfolioBenchmark> FundingAccountPortfolioBenchmark { get; set; }
        public ICollection<FundingAllocations> FundingAllocations { get; set; }
        public ICollection<FutureAccount> FutureAccount { get; set; }
        public ICollection<MonthlyFaAssetClassSplit> MonthlyFaAssetClassSplit { get; set; }
        public ICollection<TotalEquityWeightReported> TotalEquityWeightReported { get; set; }
        public ICollection<TotalEquityWeightTestHistory> TotalEquityWeightTestHistory { get; set; }
    }
}
