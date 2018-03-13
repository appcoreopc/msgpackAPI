using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class BenchmarkComponentDetail
    {
        public int BenchmarkComponentDetailId { get; set; }
        public int BenchmarkComponentId { get; set; }
        public int InstrumentId { get; set; }
        public decimal InstrumentWeight { get; set; }
        public string Currency { get; set; }
        public bool Hedging { get; set; }
        public decimal HedgingWeight { get; set; }
        public bool? ManagerLocalAud { get; set; }
        public decimal AnnualisedMargin { get; set; }
        public bool? Inactive { get; set; }

        public BenchmarkComponent BenchmarkComponent { get; set; }
        public Instrument Instrument { get; set; }
    }
}
