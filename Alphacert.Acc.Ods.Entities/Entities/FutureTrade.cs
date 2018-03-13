using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class FutureTrade
    {
        public int FutureTradeId { get; set; }
        public int PortfolioId { get; set; }
        public int InstrumentId { get; set; }
        public string CustomAccount { get; set; }
        public DateTime? StatementDate { get; set; }
        public int? Buy { get; set; }
        public int? Sell { get; set; }
        public decimal? TradePrice { get; set; }
        public string ExecutingBroker { get; set; }
        public decimal? ExecutionFees { get; set; }
        public decimal? NfaFees { get; set; }
        public decimal? ClearingFees { get; set; }
        public decimal? TotalFees { get; set; }
        public DateTime? TradeDate { get; set; }
        public string ContractCode { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string Sedol { get; set; }
        public string InstrumentType { get; set; }
        public string SettlementDate { get; set; }
        public int LoadId { get; set; }
        public int BatchId { get; set; }
        public bool? Inactive { get; set; }

        public Instrument Instrument { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
