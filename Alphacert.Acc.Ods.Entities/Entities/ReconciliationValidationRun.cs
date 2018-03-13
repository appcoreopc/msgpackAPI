using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ReconciliationValidationRun
    {
        public int ReconciliationValidationRunId { get; set; }
        public int ReconciliationValidationId { get; set; }
        public DateTime? ExecutionDateTime { get; set; }
        public int StatusId { get; set; }
        public string ResultXml { get; set; }
        public DateTime? ValuationDate { get; set; }

        public ReconciliationValidation ReconciliationValidation { get; set; }
        public Status Status { get; set; }
    }
}
