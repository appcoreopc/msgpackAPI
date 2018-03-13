using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class MeasurementGrouping
    {
        public int MeasurementGroupingId { get; set; }
        public string MeasurementGroupingName { get; set; }
        public int MeasurementId { get; set; }
        public int Sequence { get; set; }
        public string GroupByColumn { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public Measurement Measurement { get; set; }
    }
}
