using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ReconciliationDefinition
    {
        public ReconciliationDefinition()
        {
            ReconciliationDefinitionRun = new HashSet<ReconciliationDefinitionRun>();
        }

        public int ReconciliationDefinitionId { get; set; }
        public int ReconciliationId { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public string Description { get; set; }
        public bool? Inactive { get; set; }

        public Reconciliation Reconciliation { get; set; }
        public ICollection<ReconciliationDefinitionRun> ReconciliationDefinitionRun { get; set; }
    }
}
