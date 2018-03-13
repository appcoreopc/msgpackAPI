using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class EquityManagerPosition
    {
        public int EquityMgrPositionId { get; set; }
        public DateTime? ValuationDate { get; set; }
        public int? PortfolioId { get; set; }
        public int? InstrumentTypeId { get; set; }
        public string Ticker { get; set; }
        public string Currency { get; set; }
        public decimal? Units { get; set; }
        public int BatchId { get; set; }

        public InstrumentType InstrumentType { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
