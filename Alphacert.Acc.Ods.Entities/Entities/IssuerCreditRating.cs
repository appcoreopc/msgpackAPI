using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class IssuerCreditRating
    {
        public int IssuerCreditRatingId { get; set; }
        public int IssuerId { get; set; }
        public int CreditRatingId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public bool? InActive { get; set; }

        public CreditRating CreditRating { get; set; }
        public Issuer Issuer { get; set; }
    }
}
