using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Reconciliation
    {
        public Reconciliation()
        {
            ReconciliationCategoryReconciliation = new HashSet<ReconciliationCategoryReconciliation>();
            ReconciliationDefinition = new HashSet<ReconciliationDefinition>();
            ReconciliationRun = new HashSet<ReconciliationRun>();
            ReconciliationUserGroup = new HashSet<ReconciliationUserGroup>();
            ReconciliationValidationReconciliation = new HashSet<ReconciliationValidationReconciliation>();
        }

        public int ReconciliationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<ReconciliationCategoryReconciliation> ReconciliationCategoryReconciliation { get; set; }
        public ICollection<ReconciliationDefinition> ReconciliationDefinition { get; set; }
        public ICollection<ReconciliationRun> ReconciliationRun { get; set; }
        public ICollection<ReconciliationUserGroup> ReconciliationUserGroup { get; set; }
        public ICollection<ReconciliationValidationReconciliation> ReconciliationValidationReconciliation { get; set; }
    }
}
