using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Filter
    {
        public Filter()
        {
            MeasurementFilter = new HashSet<MeasurementFilter>();
        }

        public int FilterId { get; set; }
        public string FilterName { get; set; }
        public string FilterProperty { get; set; }
        public string FilterOperator { get; set; }
        public string FilterValue { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<MeasurementFilter> MeasurementFilter { get; set; }
    }
}
