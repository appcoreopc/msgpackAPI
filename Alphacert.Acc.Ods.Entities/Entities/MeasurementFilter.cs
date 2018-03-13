using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class MeasurementFilter
    {
        public int MeasurementFilterId { get; set; }
        public int MeasurementId { get; set; }
        public int FilterId { get; set; }
        public int Sequence { get; set; }
        public bool Exclusive { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public Filter Filter { get; set; }
        public Measurement Measurement { get; set; }
    }
}
