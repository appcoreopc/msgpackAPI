using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TypeSettlementPlace
    {
        public int Tspid { get; set; }
        public int? InstrumentTypeId { get; set; }
        public int CountryId { get; set; }
        public int Psetid { get; set; }

        public Country Country { get; set; }
        public InstrumentType InstrumentType { get; set; }
        public PlaceOfSettlement Pset { get; set; }
    }
}
