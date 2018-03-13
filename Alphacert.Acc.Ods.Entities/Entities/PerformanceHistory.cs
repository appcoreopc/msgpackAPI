using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class PerformanceHistory
    {
        public PerformanceHistory()
        {
            PerformanceHistoryDetails = new HashSet<PerformanceHistoryDetails>();
        }

        public int PerformanceHistoryId { get; set; }
        public DateTime ValuationDate { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDatetime { get; set; }
        public bool? IsMonthly { get; set; }
        public string Comment { get; set; }

        public Status Status { get; set; }
        public ICollection<PerformanceHistoryDetails> PerformanceHistoryDetails { get; set; }
    }
}
