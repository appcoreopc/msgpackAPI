using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class PerformanceHistoryDetails
    {
        public int PerformanceHistoryDetailsId { get; set; }
        public int PerformanceHistoryId { get; set; }
        public int? AssetClassId { get; set; }
        public int? PortfolioId { get; set; }
        public int StatusId { get; set; }
        public decimal? Navdiscounted { get; set; }
        public decimal? NavdiscountedPrevious { get; set; }
        public decimal? NavlastPrice { get; set; }
        public decimal? DailyFundingAmount { get; set; }
        public decimal? Allocations { get; set; }
        public decimal? Return { get; set; }
        public decimal? ManagerBenchmarkReturn { get; set; }
        public decimal? ManagerUnhedgedBenchmarkReturn { get; set; }
        public decimal? ReservesBenchmarkReturn { get; set; }
        public decimal? ReservesUnhedgedBenchmarkReturn { get; set; }
        public decimal? AdjustmentNavdiscounted { get; set; }
        public decimal? AdjustmentNavdiscountedPrevious { get; set; }
        public decimal? AdjustmentNavlastPrice { get; set; }
        public decimal? AdjustmentDailyFundingAmount { get; set; }
        public decimal? AdjustmentAllocations { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime LastModifiedDatetime { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDatetime { get; set; }
        public string Comment { get; set; }

        public AssetClass AssetClass { get; set; }
        public PerformanceHistory PerformanceHistory { get; set; }
        public Portfolio Portfolio { get; set; }
        public Status Status { get; set; }
    }
}
