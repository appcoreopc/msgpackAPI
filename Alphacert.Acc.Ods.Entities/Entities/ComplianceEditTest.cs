using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ComplianceEditTest
    {
        public ComplianceEditTest()
        {
            ComplianceEditTestHistory = new HashSet<ComplianceEditTestHistory>();
        }

        public int ComplianceEditTestId { get; set; }
        public string FieldName { get; set; }
        public string OriginalValue { get; set; }
        public string NewValue { get; set; }
        public string Comments { get; set; }
        public string TestAccreference { get; set; }
        public bool? Resolved { get; set; }
        public bool? Approved { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }

        public ICollection<ComplianceEditTestHistory> ComplianceEditTestHistory { get; set; }
    }
}
