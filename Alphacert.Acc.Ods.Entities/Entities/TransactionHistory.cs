using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TransactionHistory
    {
        public TransactionHistory()
        {
            TransactionLegHistory = new HashSet<TransactionLegHistory>();
        }

        public int TransactionHistoryId { get; set; }
        public int? InstrumentId { get; set; }
        public int? PortfolioId { get; set; }
        public int? TransactionTypeId { get; set; }
        public DateTime? TradeDate { get; set; }
        public bool? Inactive { get; set; }
        public string NtoriginalTransactionId { get; set; }
        public long? JpmtransactionId { get; set; }
        public int? MigrateId { get; set; }

        public InstrumentPortfolio InstrumentPortfolio { get; set; }
        public TransactionType TransactionType { get; set; }
        public ICollection<TransactionLegHistory> TransactionLegHistory { get; set; }
    }
}
