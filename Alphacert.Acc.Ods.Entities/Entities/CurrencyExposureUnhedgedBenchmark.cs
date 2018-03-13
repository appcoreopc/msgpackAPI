using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class CurrencyExposureUnhedgedBenchmark
    {
        public int CurrencyExposureBenchmarkId { get; set; }
        public int? AssetClassId { get; set; }
        public int? FundingAccountId { get; set; }
        public decimal? BenchmarkValue { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public bool? Inactive { get; set; }

        public AssetClass AssetClass { get; set; }
    }
}
