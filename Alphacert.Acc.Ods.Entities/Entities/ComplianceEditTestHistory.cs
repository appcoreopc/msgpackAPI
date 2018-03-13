using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ComplianceEditTestHistory
    {
        public int EntryId { get; set; }
        public int ComplianceEditTestId { get; set; }
        public DateTime DateTime { get; set; }
        public string UserName { get; set; }
        public string Change { get; set; }

        public ComplianceEditTest ComplianceEditTest { get; set; }
    }
}
