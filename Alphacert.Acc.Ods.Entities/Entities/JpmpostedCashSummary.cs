using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class JpmpostedCashSummary
    {
        public JpmpostedCashSummary()
        {
            JpmpostedCashDetail = new HashSet<JpmpostedCashDetail>();
        }

        public long JpmpostedCashSummaryId { get; set; }
        public int PortfolioId { get; set; }
        public string AccountNumber { get; set; }
        public int? CashAccountNumber { get; set; }
        public DateTime PostedDate { get; set; }
        public string CurrencyCode { get; set; }
        public string TransactionGroupDescription { get; set; }
        public decimal? TransactionGroupAmount { get; set; }
        public int BatchId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? Inactive { get; set; }

        public Portfolio Portfolio { get; set; }
        public ICollection<JpmpostedCashDetail> JpmpostedCashDetail { get; set; }
    }
}
