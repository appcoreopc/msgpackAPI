using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class DiscountFactors
    {
        public int DiscountFactorsId { get; set; }
        public int BatchId { get; set; }
        public int LoadId { get; set; }
        public long StageRowId { get; set; }
        public int InstrumentId { get; set; }
        public DateTime ValuationDate { get; set; }
        public string ExtraColumn { get; set; }
        public decimal DiscountRate { get; set; }
        public bool? Inactive { get; set; }
        public decimal? HoldingPercent { get; set; }
        public int? DiscountConfigId { get; set; }

        public DiscountConfig DiscountConfig { get; set; }
        public Instrument Instrument { get; set; }
    }
}
