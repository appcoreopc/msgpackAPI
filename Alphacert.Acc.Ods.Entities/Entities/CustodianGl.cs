using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class CustodianGl
    {
        public CustodianGl()
        {
            CustodianGlhistory = new HashSet<CustodianGlhistory>();
        }

        public int Glid { get; set; }
        public DateTime EndDate { get; set; }
        public int Glaccount { get; set; }
        public string AccountDesc { get; set; }
        public decimal? Movement { get; set; }
        public decimal? EndBalance { get; set; }
        public int PortfolioId { get; set; }
        public int? LoadId { get; set; }
        public bool? InActive { get; set; }
        public int? BatchId { get; set; }
        public int? GlstatusHistoryId { get; set; }

        public GlstatusHistory GlstatusHistory { get; set; }
        public Portfolio Portfolio { get; set; }
        public ICollection<CustodianGlhistory> CustodianGlhistory { get; set; }
    }
}
