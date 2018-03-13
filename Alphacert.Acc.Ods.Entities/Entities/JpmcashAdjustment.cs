using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class JpmcashAdjustment
    {
        public long JpmcashAdjustmentId { get; set; }
        public int PortfolioId { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime AdjustmentDate { get; set; }
        public DateTime? ProjectedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public decimal Value { get; set; }
        public string Comment { get; set; }
        public int StatusId { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDateTime { get; set; }
        public bool? Inactive { get; set; }
        public long? TableId { get; set; }
        public string TransactionGroupDescription { get; set; }
        public string Table { get; set; }
        public int CashAdjustmentSubTypeId { get; set; }

        public CashAdjustmentSubType CashAdjustmentSubType { get; set; }
        public Portfolio Portfolio { get; set; }
        public Status Status { get; set; }
    }
}
