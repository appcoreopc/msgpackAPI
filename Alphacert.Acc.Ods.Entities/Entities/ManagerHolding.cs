using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ManagerHolding
    {
        public long ManagerHoldingId { get; set; }
        public string IntDom { get; set; }
        public int PortfolioId { get; set; }
        public string Ticker { get; set; }
        public string Sedol { get; set; }
        public int? InstrumentId { get; set; }
        public decimal Units { get; set; }
        public int LoadId { get; set; }

        public Instrument Instrument { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
