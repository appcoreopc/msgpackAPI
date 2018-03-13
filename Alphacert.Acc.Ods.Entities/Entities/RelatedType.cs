using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class RelatedType
    {
        public RelatedType()
        {
            InstrumentRelationship = new HashSet<InstrumentRelationship>();
        }

        public int RelatedTypeId { get; set; }
        public string RelatedTypeCode { get; set; }
        public string RelatedTypeCodeDesc { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<InstrumentRelationship> InstrumentRelationship { get; set; }
    }
}
