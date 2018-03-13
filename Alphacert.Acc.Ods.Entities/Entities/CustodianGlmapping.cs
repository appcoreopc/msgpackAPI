using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class CustodianGlmapping
    {
        public int Glaccount { get; set; }
        public int InstrumentClassificationId { get; set; }

        public InstrumentClassification InstrumentClassification { get; set; }
    }
}
