using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ComplianceApproval
    {
        public ComplianceApproval()
        {
            ComplianceApprovalHistory = new HashSet<ComplianceApprovalHistory>();
        }

        public DateTime ValuationDate { get; set; }
        public bool? Final { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
        public bool? Approved { get; set; }
        public DateTime TimeLastModified { get; set; }

        public ICollection<ComplianceApprovalHistory> ComplianceApprovalHistory { get; set; }
    }
}
