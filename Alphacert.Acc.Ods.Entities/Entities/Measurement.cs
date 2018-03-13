using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Measurement
    {
        public Measurement()
        {
            MeasurementFilter = new HashSet<MeasurementFilter>();
            MeasurementGrouping = new HashSet<MeasurementGrouping>();
            TestRangeDynamic = new HashSet<TestRangeDynamic>();
            TestStep = new HashSet<TestStep>();
        }

        public int MeasurementId { get; set; }
        public int MeasureId { get; set; }
        public string MeasurementName { get; set; }
        public string MeasurementFunction { get; set; }
        public string MeasurementDomain { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public Measure Measure { get; set; }
        public ICollection<MeasurementFilter> MeasurementFilter { get; set; }
        public ICollection<MeasurementGrouping> MeasurementGrouping { get; set; }
        public ICollection<TestRangeDynamic> TestRangeDynamic { get; set; }
        public ICollection<TestStep> TestStep { get; set; }
    }
}
