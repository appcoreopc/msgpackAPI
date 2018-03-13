using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AssetAllocation
    {
        public int AssetAllocationId { get; set; }
        public string RefNum { get; set; }
        public DateTime ValuationDate { get; set; }
        public string Comment { get; set; }
        public string TransferFrom { get; set; }
        public string TransferTo { get; set; }
        public int? FromPortfolioId { get; set; }
        public int? ToPortfolioId { get; set; }
        public decimal? RevalRates { get; set; }
        public decimal? DealtRates { get; set; }
        public decimal? Earners { get; set; }
        public decimal? ResidualEmployers { get; set; }
        public decimal? MotorVehicle { get; set; }
        public decimal? NewEmployers { get; set; }
        public decimal? SelfEmployed { get; set; }
        public decimal? NonEarners { get; set; }
        public decimal? TreatmentInjury { get; set; }
        public bool? Inactive { get; set; }

        public Portfolio FromPortfolio { get; set; }
        public Portfolio ToPortfolio { get; set; }
    }
}
