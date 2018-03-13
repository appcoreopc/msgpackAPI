using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Fimanager
    {
        public int FimanagerId { get; set; }
        public int BatchId { get; set; }
        public int LoadId { get; set; }
        public int PortfolioId { get; set; }
        public string CustodianCode { get; set; }
        public int? InstrumentId { get; set; }
        public string Isin { get; set; }
        public decimal? FaceValue { get; set; }
        public DateTime? WhenCreated { get; set; }

        public Instrument Instrument { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
