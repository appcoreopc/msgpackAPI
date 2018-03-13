using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Country
    {
        public Country()
        {
            CountrySector = new HashSet<CountrySector>();
            Exchange = new HashSet<Exchange>();
            RegionCountryMapping = new HashSet<RegionCountryMapping>();
            TypeSettlementPlace = new HashSet<TypeSettlementPlace>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Iso2charCode { get; set; }
        public string Iso3charCode { get; set; }
        public string Currency { get; set; }
        public bool? PrimaryCurrency { get; set; }
        public int? StandardSettlement { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<CountrySector> CountrySector { get; set; }
        public ICollection<Exchange> Exchange { get; set; }
        public ICollection<RegionCountryMapping> RegionCountryMapping { get; set; }
        public ICollection<TypeSettlementPlace> TypeSettlementPlace { get; set; }
    }
}
