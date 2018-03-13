using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class BenchmarkComponent
    {
        public BenchmarkComponent()
        {
            BenchmarkComponentDetail = new HashSet<BenchmarkComponentDetail>();
        }

        public int BenchmarkComponentId { get; set; }
        public string BenchmarkType { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public int? PortfolioId { get; set; }
        public int? AssetClassId { get; set; }
        public int StatusId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDateTime { get; set; }
        public bool? Inactive { get; set; }

        public AssetClass AssetClass { get; set; }
        public Portfolio Portfolio { get; set; }
        public Status Status { get; set; }
        public ICollection<BenchmarkComponentDetail> BenchmarkComponentDetail { get; set; }
    }
}
