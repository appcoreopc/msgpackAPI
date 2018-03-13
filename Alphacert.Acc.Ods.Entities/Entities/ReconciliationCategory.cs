using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ReconciliationCategory
    {
        public ReconciliationCategory()
        {
            ReconciliationCategoryReconciliation = new HashSet<ReconciliationCategoryReconciliation>();
        }

        public int ReconciliationCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<ReconciliationCategoryReconciliation> ReconciliationCategoryReconciliation { get; set; }
    }
}
