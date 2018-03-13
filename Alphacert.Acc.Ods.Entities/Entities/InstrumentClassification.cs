using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentClassification
    {
        public InstrumentClassification()
        {
            AutoClassificationMapping = new HashSet<AutoClassificationMapping>();
            CustodianGlmapping = new HashSet<CustodianGlmapping>();
            InstrumentClassificationHistory = new HashSet<InstrumentClassificationHistory>();
            InverseParentInstrumentClassification = new HashSet<InstrumentClassification>();
        }

        public int InstrumentClassificationId { get; set; }
        public string InstrumentClassificationDesc { get; set; }
        public string Code { get; set; }
        public int InstrumentClassificationTypeId { get; set; }
        public int? ParentInstrumentClassificationId { get; set; }
        public bool? Inactive { get; set; }

        public InstrumentClassificationType InstrumentClassificationType { get; set; }
        public InstrumentClassification ParentInstrumentClassification { get; set; }
        public ICollection<AutoClassificationMapping> AutoClassificationMapping { get; set; }
        public ICollection<CustodianGlmapping> CustodianGlmapping { get; set; }
        public ICollection<InstrumentClassificationHistory> InstrumentClassificationHistory { get; set; }
        public ICollection<InstrumentClassification> InverseParentInstrumentClassification { get; set; }
    }
}
