using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class OracleGl
    {
        public int OracleGlid { get; set; }
        public DateTime EndDate { get; set; }
        public int AccountCode { get; set; }
        public string AccountDesc { get; set; }
        public decimal EndBalance { get; set; }
        public int PortfolioId { get; set; }
        public bool? Inactive { get; set; }
        public int BatchId { get; set; }
        public string CostCentre { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
