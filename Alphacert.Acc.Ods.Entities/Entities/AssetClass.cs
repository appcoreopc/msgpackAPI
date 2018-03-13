using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AssetClass
    {
        public AssetClass()
        {
            BenchmarkComponent = new HashSet<BenchmarkComponent>();
            CurrencyExposureUnhedgedBenchmark = new HashSet<CurrencyExposureUnhedgedBenchmark>();
            FundingAccountAssetClassBenchmark = new HashSet<FundingAccountAssetClassBenchmark>();
            FundingAccountAssetClassSplit = new HashSet<FundingAccountAssetClassSplit>();
            MonthlyFaAssetClassSplit = new HashSet<MonthlyFaAssetClassSplit>();
            PerformanceHistoryDetails = new HashSet<PerformanceHistoryDetails>();
            PortfolioAssetClass = new HashSet<PortfolioAssetClass>();
        }

        public int AssetClassId { get; set; }
        public string AssetClassName { get; set; }
        public bool? Inactive { get; set; }
        public int? PerformanceOrder { get; set; }

        public ICollection<BenchmarkComponent> BenchmarkComponent { get; set; }
        public ICollection<CurrencyExposureUnhedgedBenchmark> CurrencyExposureUnhedgedBenchmark { get; set; }
        public ICollection<FundingAccountAssetClassBenchmark> FundingAccountAssetClassBenchmark { get; set; }
        public ICollection<FundingAccountAssetClassSplit> FundingAccountAssetClassSplit { get; set; }
        public ICollection<MonthlyFaAssetClassSplit> MonthlyFaAssetClassSplit { get; set; }
        public ICollection<PerformanceHistoryDetails> PerformanceHistoryDetails { get; set; }
        public ICollection<PortfolioAssetClass> PortfolioAssetClass { get; set; }
    }
}
