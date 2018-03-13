using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class GlstatusHistory
    {
        public GlstatusHistory()
        {
            CustodianGl = new HashSet<CustodianGl>();
        }

        public int GlstatusHistoryId { get; set; }
        public int? BatchId { get; set; }
        public int PortfolioId { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? Created { get; set; }
        public bool? Inactive { get; set; }
        public int GlstatusId { get; set; }
        public bool? Verified { get; set; }
        public string Comment { get; set; }

        public Glstatus Glstatus { get; set; }
        public ICollection<CustodianGl> CustodianGl { get; set; }
    }
}
