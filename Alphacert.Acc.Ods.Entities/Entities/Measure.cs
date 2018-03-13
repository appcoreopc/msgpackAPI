using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Measure
    {
        public Measure()
        {
            Measurement = new HashSet<Measurement>();
        }

        public int MeasureId { get; set; }
        public string MeasureName { get; set; }
        public int MeasureTypeId { get; set; }
        public string DataSource { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public MeasureType MeasureType { get; set; }
        public ICollection<Measurement> Measurement { get; set; }
    }
}
