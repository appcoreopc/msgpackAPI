using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentClassificationType
    {
        public InstrumentClassificationType()
        {
            InstrumentClassification = new HashSet<InstrumentClassification>();
        }

        public int InstrumentClassificationTypeId { get; set; }
        public string InstrumentClassificationTypeDesc { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<InstrumentClassification> InstrumentClassification { get; set; }
    }
}
