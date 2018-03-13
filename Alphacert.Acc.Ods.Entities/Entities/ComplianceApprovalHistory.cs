using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ComplianceApprovalHistory
    {
        public DateTime ValuationDate { get; set; }
        public bool? Final { get; set; }
        public int Version { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
        public bool? Approved { get; set; }
        public DateTime TimeCreated { get; set; }

        public ComplianceApproval ComplianceApproval { get; set; }
    }
}
