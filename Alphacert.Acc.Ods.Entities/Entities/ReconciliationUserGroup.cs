using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ReconciliationUserGroup
    {
        public int ReconciliationId { get; set; }
        public int RoleId { get; set; }
        public bool? CanApprove { get; set; }

        public Reconciliation Reconciliation { get; set; }
    }
}
