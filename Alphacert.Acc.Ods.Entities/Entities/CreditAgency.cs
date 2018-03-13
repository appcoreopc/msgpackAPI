using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class CreditAgency
    {
        public CreditAgency()
        {
            CreditRating = new HashSet<CreditRating>();
        }

        public int CreditAgencyId { get; set; }
        public string CreditAgencyCode { get; set; }
        public string CreditAgencyName { get; set; }
        public bool? InActive { get; set; }

        public ICollection<CreditRating> CreditRating { get; set; }
    }
}
