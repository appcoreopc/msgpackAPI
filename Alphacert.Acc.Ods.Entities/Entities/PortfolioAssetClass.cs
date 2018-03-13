using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class PortfolioAssetClass
    {
        public int PortfolioId { get; set; }
        public int AssetClassId { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool? Inactive { get; set; }

        public AssetClass AssetClass { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
