using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TradeConfirmation
    {
        public int TradeConfirmationId { get; set; }
        public int? TradeId { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public bool? InActive { get; set; }
        public int CounterPartyId { get; set; }
        public DateTime TradeDate { get; set; }
        public DateTime SettlementDate { get; set; }
        public string Ticker { get; set; }
        public string Sedol { get; set; }
        public string Isin { get; set; }
        public int TransactionTypeId { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? Commision { get; set; }
        public decimal? Fees { get; set; }
        public decimal SettlementAmount { get; set; }
        public string InstrumentName { get; set; }

        public CounterParty CounterParty { get; set; }
        public Trade Trade { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
