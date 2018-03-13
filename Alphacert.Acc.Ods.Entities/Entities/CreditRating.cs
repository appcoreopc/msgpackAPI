using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class CreditRating
    {
        public CreditRating()
        {
            InstrumentCreditRating = new HashSet<InstrumentCreditRating>();
            IssuerCreditRating = new HashSet<IssuerCreditRating>();
        }

        public int CreditRatingId { get; set; }
        public int CreditAgencyId { get; set; }
        public string CreditRatingType { get; set; }
        public int Priority { get; set; }
        public string CreditRatingCode { get; set; }
        public int SaPequivalentRating { get; set; }
        public bool? InActive { get; set; }
        public int? SaPequivalentLongTermRating { get; set; }
        public int SaPequivalentLongTermHighest { get; set; }

        public CreditAgency CreditAgency { get; set; }
        public ICollection<InstrumentCreditRating> InstrumentCreditRating { get; set; }
        public ICollection<IssuerCreditRating> IssuerCreditRating { get; set; }
    }
}
