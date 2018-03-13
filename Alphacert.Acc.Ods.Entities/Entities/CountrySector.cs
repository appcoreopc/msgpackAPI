using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class CountrySector
    {
        public int CountrySectorId { get; set; }
        public string JpmsectorLevel4 { get; set; }
        public int? CountryId { get; set; }

        public Country Country { get; set; }
    }
}
