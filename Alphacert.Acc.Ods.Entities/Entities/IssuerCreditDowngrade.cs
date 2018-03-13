using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class IssuerCreditDowngrade
    {
        public int IssuerCreditDowngradeId { get; set; }
        public int IssuerId { get; set; }
        public int CurrentIssuerCreditRatingId { get; set; }
        public int PreviousIssuerCreditRatingId { get; set; }
        public DateTime ValuationDate { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? InActive { get; set; }
    }
}
