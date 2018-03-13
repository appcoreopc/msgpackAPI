using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AccprojectionApproval
    {
        public int AccprojectionApprovalId { get; set; }
        public DateTime PostedDate { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDateTime { get; set; }
        public string Comment { get; set; }
        public bool? Inactive { get; set; }

        public Status Status { get; set; }
    }
}
