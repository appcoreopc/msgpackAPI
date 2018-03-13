using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ReconciliationValidation
    {
        public ReconciliationValidation()
        {
            ReconciliationValidationReconciliation = new HashSet<ReconciliationValidationReconciliation>();
            ReconciliationValidationRun = new HashSet<ReconciliationValidationRun>();
        }

        public int ReconciliationValidationId { get; set; }
        public string Name { get; set; }
        public string Validation { get; set; }
        public string Description { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<ReconciliationValidationReconciliation> ReconciliationValidationReconciliation { get; set; }
        public ICollection<ReconciliationValidationRun> ReconciliationValidationRun { get; set; }
    }
}
