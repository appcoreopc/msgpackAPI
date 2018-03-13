using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ReconciliationCategoryReconciliation
    {
        public int ReconciliationCategoryId { get; set; }
        public int ReconciliationId { get; set; }

        public Reconciliation Reconciliation { get; set; }
        public ReconciliationCategory ReconciliationCategory { get; set; }
    }
}
