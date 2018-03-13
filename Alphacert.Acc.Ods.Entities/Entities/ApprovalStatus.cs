using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ApprovalStatus
    {
        public ApprovalStatus()
        {
            CustodianGlhistory = new HashSet<CustodianGlhistory>();
            InstrumentClassificationHistory = new HashSet<InstrumentClassificationHistory>();
        }

        public int ApprovalStatusId { get; set; }
        public string StatusCode { get; set; }
        public string Description { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<CustodianGlhistory> CustodianGlhistory { get; set; }
        public ICollection<InstrumentClassificationHistory> InstrumentClassificationHistory { get; set; }
    }
}
