using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class PlaceOfSettlement
    {
        public PlaceOfSettlement()
        {
            Ssi = new HashSet<Ssi>();
            Ssihistory = new HashSet<Ssihistory>();
            TypeSettlementPlace = new HashSet<TypeSettlementPlace>();
        }

        public int Psetid { get; set; }
        public string PsetcountryCode { get; set; }
        public string Psetname { get; set; }
        public string Psetbic { get; set; }
        public string PsetexecutingBkrPrimary { get; set; }
        public string PsetexecutingBkrSecondary { get; set; }
        public string PsetexecutingBkrTertiary { get; set; }
        public string PsetclearingBkrPrimary { get; set; }
        public string PsetclearingBkrSecondary { get; set; }
        public string PsetclearingBkrTertiary { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<Ssi> Ssi { get; set; }
        public ICollection<Ssihistory> Ssihistory { get; set; }
        public ICollection<TypeSettlementPlace> TypeSettlementPlace { get; set; }
    }
}
