using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AccadjustmentHistory
    {
        public int AdjustmentHistoryId { get; set; }
        public DateTime? WhenCreated { get; set; }
        public string WhoChanged { get; set; }
        public int? AjustmentStatusId { get; set; }
        public string Comments { get; set; }
        public int? HoldingId { get; set; }
        public decimal? MarketValueBase { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Ifrs { get; set; }
        public bool? Inactive { get; set; }

        public AccadjustmentStatus AjustmentStatus { get; set; }
        public Holding Holding { get; set; }
    }
}
