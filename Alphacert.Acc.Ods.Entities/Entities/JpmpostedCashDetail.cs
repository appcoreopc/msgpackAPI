﻿using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class JpmpostedCashDetail
    {
        public long JpmpostedCashDetailId { get; set; }
        public long? JpmpostedCashSummaryId { get; set; }
        public int PortfolioId { get; set; }
        public string AccountNumber { get; set; }
        public int? CashAccountNumber { get; set; }
        public DateTime? PostedDate { get; set; }
        public string CurrencyCode { get; set; }
        public string TransactionGroupDescription { get; set; }
        public string SecurityName { get; set; }
        public string TransactionNumber { get; set; }
        public string TransactionTypeDescription { get; set; }
        public string AssetTypeDescription { get; set; }
        public string SecurityId { get; set; }
        public string Isin { get; set; }
        public string Ticker { get; set; }
        public int? Units { get; set; }
        public decimal? Price { get; set; }
        public decimal? NetAmount { get; set; }
        public DateTime? TradeDate { get; set; }
        public DateTime? ContractualSd { get; set; }
        public string ClearingBrokerName { get; set; }
        public string AdditionalInformation { get; set; }
        public int BatchId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? Inactive { get; set; }

        public JpmpostedCashSummary JpmpostedCashSummary { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
