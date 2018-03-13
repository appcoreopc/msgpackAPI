using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ReconciliationRun
    {
        public ReconciliationRun()
        {
            ReconciliationDefinitionRun = new HashSet<ReconciliationDefinitionRun>();
        }

        public int ReconciliationRunId { get; set; }
        public int ReconciliationId { get; set; }
        public DateTime ValuationDate { get; set; }
        public string Source { get; set; }
        public string UserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? ExecutionDateTime { get; set; }
        public int StatusId { get; set; }
        public string Comment { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }

        public Reconciliation Reconciliation { get; set; }
        public Status Status { get; set; }
        public ICollection<ReconciliationDefinitionRun> ReconciliationDefinitionRun { get; set; }
    }
}
