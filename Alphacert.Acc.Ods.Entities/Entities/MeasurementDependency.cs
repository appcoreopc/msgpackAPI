using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class MeasurementDependency
    {
        public int MeasurementDependencyId { get; set; }
        public string MeasurementName { get; set; }
        public string TestAccreference { get; set; }
    }
}
