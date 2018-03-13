using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ReconciliationValidationReconciliation
    {
        public int ReconciliationValidationId { get; set; }
        public int ReconciliationId { get; set; }

        public Reconciliation Reconciliation { get; set; }
        public ReconciliationValidation ReconciliationValidation { get; set; }
    }
}
