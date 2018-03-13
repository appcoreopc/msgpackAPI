using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class BbaimaccountStatus
    {
        public int PortfolioId { get; set; }
        public string BbaimaccountCode { get; set; }
        public string BbaimlastRefId { get; set; }
        public DateTime? LastProcessedDate { get; set; }
        public bool? Inactive { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
