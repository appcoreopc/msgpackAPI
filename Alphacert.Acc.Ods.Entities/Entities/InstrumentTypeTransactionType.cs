using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentTypeTransactionType
    {
        public int InstrumentTypeId { get; set; }
        public int TransactionTypeId { get; set; }
        public bool? Inactive { get; set; }

        public InstrumentType InstrumentType { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
