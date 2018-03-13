using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class RegionCountryMapping
    {
        public int RegionId { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
        public Region Region { get; set; }
    }
}
