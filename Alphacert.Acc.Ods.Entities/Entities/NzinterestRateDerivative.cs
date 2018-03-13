using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class NzinterestRateDerivative
    {
        public int NzinterestRateDerivativeId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal EffectiveExposure { get; set; }
        public decimal FaceValue { get; set; }
        public decimal MarketValue { get; set; }
        public bool? Inactive { get; set; }
        public decimal? EffectiveExposureEarners { get; set; }
        public decimal? EffectiveExposureResidualEmployers { get; set; }
        public decimal? EffectiveExposureMotorVehicle { get; set; }
        public decimal? EffectiveExposureNewEmployers { get; set; }
        public decimal? EffectiveExposureSelfEmployed { get; set; }
        public decimal? EffectiveExposureNonEarners { get; set; }
        public decimal? EffectiveExposureTreatmentInjury { get; set; }
    }
}
