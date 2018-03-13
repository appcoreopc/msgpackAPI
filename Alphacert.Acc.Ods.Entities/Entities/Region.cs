using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Region
    {
        public Region()
        {
            RegionCountryMapping = new HashSet<RegionCountryMapping>();
        }

        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public string RegionCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? WhenCreated { get; set; }
        public bool? Inactive { get; set; }
        public int? RimesbenchmarkInstrumentId { get; set; }

        public ICollection<RegionCountryMapping> RegionCountryMapping { get; set; }
    }
}
