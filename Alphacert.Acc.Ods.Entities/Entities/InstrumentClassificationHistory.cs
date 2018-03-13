using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentClassificationHistory
    {
        public int InstrumentClassificationHistoryId { get; set; }
        public int InstrumentId { get; set; }
        public int InstrumentClassificationId { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        public bool? Inactive { get; set; }
        public int? ApprovalStatusId { get; set; }
        public string WhoChanged { get; set; }
        public string WhoChecked { get; set; }
        public DateTime? PreviousActiveTo { get; set; }

        public ApprovalStatus ApprovalStatus { get; set; }
        public Instrument Instrument { get; set; }
        public InstrumentClassification InstrumentClassification { get; set; }
    }
}
