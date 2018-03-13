using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class DiscountConfig
    {
        public DiscountConfig()
        {
            DiscountFactors = new HashSet<DiscountFactors>();
        }

        public int DiscountConfigId { get; set; }
        public decimal Threshold { get; set; }
        public string Gicsprefix { get; set; }
        public string Exchange { get; set; }
        public int? Order { get; set; }
        public decimal? Rounding { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<DiscountFactors> DiscountFactors { get; set; }
    }
}
