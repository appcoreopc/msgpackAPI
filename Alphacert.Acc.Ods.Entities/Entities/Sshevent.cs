using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Sshevent
    {
        public int SsheventId { get; set; }
        public int SshentityId { get; set; }
        public DateTime ValuationDate { get; set; }
        public decimal? ShareholdingPercentage { get; set; }
        public int SsheventTypeId { get; set; }
        public DateTime? DateNotified { get; set; }
        public string EventComment { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? InActive { get; set; }
        public int? SshtestId { get; set; }
        public decimal? ThresholdPercent { get; set; }
        public string NotifiedBy { get; set; }
        public decimal? Shares { get; set; }
        public decimal? SharesOnIssue { get; set; }

        public Sshentity Sshentity { get; set; }
        public SsheventType SsheventType { get; set; }
        public Sshtest Sshtest { get; set; }
    }
}
