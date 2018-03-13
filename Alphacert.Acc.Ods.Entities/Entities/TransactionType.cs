using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            InstrumentTypeTransactionType = new HashSet<InstrumentTypeTransactionType>();
            Trade = new HashSet<Trade>();
            TradeConfirmation = new HashSet<TradeConfirmation>();
            Transaction = new HashSet<Transaction>();
            TransactionHistory = new HashSet<TransactionHistory>();
        }

        public int TransactionTypeId { get; set; }
        public string TransactionTypeDesc { get; set; }
        public string TransactionTypeCode { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<InstrumentTypeTransactionType> InstrumentTypeTransactionType { get; set; }
        public ICollection<Trade> Trade { get; set; }
        public ICollection<TradeConfirmation> TradeConfirmation { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
        public ICollection<TransactionHistory> TransactionHistory { get; set; }
    }
}
