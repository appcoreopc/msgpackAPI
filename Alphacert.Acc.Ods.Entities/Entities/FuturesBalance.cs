using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class FuturesBalance
    {
        public int FutureBalanceId { get; set; }
        public int PortfolioId { get; set; }
        public int InstrumentId { get; set; }
        public int StagingRowId { get; set; }
        public string CustomAccount { get; set; }
        public DateTime? StatementDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? OpeningBalance { get; set; }
        public decimal? ClosingBalance { get; set; }
        public decimal? OpenTradeEquity { get; set; }
        public decimal? TotalEquity { get; set; }
        public decimal? InitialMarginRequirement { get; set; }
        public decimal? MaintenanceMarginRequirement { get; set; }
        public int LoadId { get; set; }
        public int BatchId { get; set; }
        public bool? InActive { get; set; }

        public Instrument Instrument { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
