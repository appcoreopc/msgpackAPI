using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class CustodianGlhistory
    {
        public int GlhistoryId { get; set; }
        public DateTime EndDate { get; set; }
        public int? Glaccount { get; set; }
        public decimal Movement { get; set; }
        public int? Glid { get; set; }
        public int PortfolioId { get; set; }
        public bool? InActive { get; set; }
        public int ApprovalStatusId { get; set; }
        public DateTime? WhenCreated { get; set; }
        public string WhoChanged { get; set; }
        public string Comments { get; set; }

        public ApprovalStatus ApprovalStatus { get; set; }
        public CustodianGl Gl { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
