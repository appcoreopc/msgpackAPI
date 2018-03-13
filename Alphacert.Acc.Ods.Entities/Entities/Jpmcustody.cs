using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Jpmcustody
    {
        public int JpmcustodyId { get; set; }
        public int PortfolioId { get; set; }
        public DateTime ValuationDate { get; set; }
        public string SecurityName { get; set; }
        public int? InstrumentId { get; set; }
        public string Isin { get; set; }
        public string Sedol { get; set; }
        public string Ticker { get; set; }
        public string CountryCode { get; set; }
        public decimal AwaitingReceipt { get; set; }
        public decimal AwaitingDelivery { get; set; }
        public decimal TotalUnits { get; set; }
        public int BatchId { get; set; }

        public Instrument Instrument { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
