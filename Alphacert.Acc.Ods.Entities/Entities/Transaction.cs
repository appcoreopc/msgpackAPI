using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Transaction
    {
        public Transaction()
        {
            TradeTransaction = new HashSet<Trade>();
            TradeTransaction2 = new HashSet<Trade>();
            TransactionLeg = new HashSet<TransactionLeg>();
        }

        public int TransactionId { get; set; }
        public int? InstrumentId { get; set; }
        public int? PortfolioId { get; set; }
        public int? TransactionTypeId { get; set; }
        public DateTime? TradeDate { get; set; }
        public bool? Inactive { get; set; }
        public string NtoriginalTransactionId { get; set; }
        public long? JpmtransactionId { get; set; }
        public int? BatchId { get; set; }

        public InstrumentPortfolio InstrumentPortfolio { get; set; }
        public TransactionType TransactionType { get; set; }
        public ICollection<Trade> TradeTransaction { get; set; }
        public ICollection<Trade> TradeTransaction2 { get; set; }
        public ICollection<TransactionLeg> TransactionLeg { get; set; }
    }
}
