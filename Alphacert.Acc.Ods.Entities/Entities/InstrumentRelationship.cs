using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentRelationship
    {
        public int InstrumentRelationshipId { get; set; }
        public int PrimaryInstrumentId { get; set; }
        public int RelatedInstrumentId { get; set; }
        public int? RelatedTypeId { get; set; }
        public bool? Inactive { get; set; }
        public int? BatchId { get; set; }

        public Instrument PrimaryInstrument { get; set; }
        public Instrument RelatedInstrument { get; set; }
        public RelatedType RelatedType { get; set; }
    }
}
