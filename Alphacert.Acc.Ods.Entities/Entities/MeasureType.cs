using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class MeasureType
    {
        public MeasureType()
        {
            Measure = new HashSet<Measure>();
        }

        public int MeasureTypeId { get; set; }
        public string MeasureTypeName { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<Measure> Measure { get; set; }
    }
}
