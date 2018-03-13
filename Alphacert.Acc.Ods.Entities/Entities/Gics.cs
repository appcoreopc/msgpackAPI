using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Gics
    {
        public int Gicsid { get; set; }
        public string SectorCode { get; set; }
        public string SectorName { get; set; }
        public string IndustryGroupCode { get; set; }
        public string IndustryGroupName { get; set; }
        public string IndustryCode { get; set; }
        public string IndustryName { get; set; }
        public string SubIndustryCode { get; set; }
        public string SubIndustryName { get; set; }
        public bool? Inactive { get; set; }
    }
}
