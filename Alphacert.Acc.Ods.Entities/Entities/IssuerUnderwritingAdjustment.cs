using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class IssuerUnderwritingAdjustment
    {
        public int IssuerUnderwritingAdjustmentId { get; set; }
        public int IssuerId { get; set; }
        public string Description { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public string Currency { get; set; }
        public decimal ValueLocal { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Inactive { get; set; }

        public Issuer Issuer { get; set; }
    }
}
