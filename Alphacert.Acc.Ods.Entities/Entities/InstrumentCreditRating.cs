using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentCreditRating
    {
        public int InstrumentCreditRatingId { get; set; }
        public int InstrumentId { get; set; }
        public int CreditRatingId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public bool? InActive { get; set; }

        public CreditRating CreditRating { get; set; }
        public Instrument Instrument { get; set; }
    }
}
