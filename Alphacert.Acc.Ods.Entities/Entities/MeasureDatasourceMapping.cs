using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class MeasureDatasourceMapping
    {
        public string MeasureName { get; set; }
        public string DatasourceName { get; set; }
        public string DatasourceType { get; set; }
        public bool? DateFilter { get; set; }
    }
}
