using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AutoClassificationMapping
    {
        public int AutoClassificationMappingId { get; set; }
        public int InstrumentTypeId { get; set; }
        public int InstrumentSubTypeId { get; set; }
        public string Country { get; set; }
        public int InstrumentClassificationId { get; set; }

        public InstrumentClassification InstrumentClassification { get; set; }
        public InstrumentSubType InstrumentSubType { get; set; }
        public InstrumentType InstrumentType { get; set; }
    }
}
