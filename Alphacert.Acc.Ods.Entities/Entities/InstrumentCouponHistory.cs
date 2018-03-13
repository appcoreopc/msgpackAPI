using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentCouponHistory
    {
        public int InstrumentCouponHistoryId { get; set; }
        public int InstrumentId { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ValuationDate { get; set; }
        public string Rate { get; set; }

        public Instrument Instrument { get; set; }
    }
}
