using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class JpmpostedCashBalance
    {
        public long JpmpostedCashBalanceId { get; set; }
        public int PortfolioId { get; set; }
        public string AccountNumber { get; set; }
        public int? CashAccountNumber { get; set; }
        public DateTime PostedDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? CashOpeningBalance { get; set; }
        public decimal? CashClosingBalance { get; set; }
        public int BatchId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? Inactive { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
