using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TradeConfirmationFx
    {
        public int TradeConfirmationFxid { get; set; }
        public int? TradeId { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public int? BatchId { get; set; }
        public int? LoadId { get; set; }
        public bool? InActive { get; set; }
        public string ContractNumber { get; set; }
        public int CounterPartyId { get; set; }
        public DateTime TradeDate { get; set; }
        public DateTime SettlementDate { get; set; }
        public decimal SellAmount { get; set; }
        public string SellCurrency { get; set; }
        public decimal BuyAmount { get; set; }
        public string BuyCurrency { get; set; }
        public decimal? Rate { get; set; }
        public string ProductType { get; set; }
        public string AccountName { get; set; }
        public string SourceSystemTradeId { get; set; }

        public CounterParty CounterParty { get; set; }
        public Trade Trade { get; set; }
    }
}
