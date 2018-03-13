using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class FuturePosition
    {
        public int FuturePositionId { get; set; }
        public int PortfolioId { get; set; }
        public int InstrumentId { get; set; }
        public string CustomAccount { get; set; }
        public DateTime? StatementDate { get; set; }
        public decimal? SettlementPrice { get; set; }
        public int? NetPosition { get; set; }
        public decimal? UnrealizedPL { get; set; }
        public int? LongPosition { get; set; }
        public int? ShortPosition { get; set; }
        public string ContractCode { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string Sedol { get; set; }
        public int LoadId { get; set; }
        public int BatchId { get; set; }
        public bool? Inactive { get; set; }
        public decimal? DeltaFactor { get; set; }
        public decimal? DeltaQuotient { get; set; }
        public DateTime? OptionExpiryDate { get; set; }
        public string BloombergTicker { get; set; }

        public Instrument Instrument { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
