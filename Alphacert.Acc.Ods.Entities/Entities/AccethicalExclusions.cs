using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AccethicalExclusions
    {
        public int AccethicalExclusionsId { get; set; }
        public string CompanyName { get; set; }
        public string BbglobalCompanyId { get; set; }
        public string BbcompanyId { get; set; }
        public string Isin { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool? Tobacco { get; set; }
        public bool? NuclearWeapons { get; set; }
        public bool? AntiPersonnelMines { get; set; }
        public bool? ClusterMunitions { get; set; }
        public bool? CorporateBehavior { get; set; }
        public bool? Inactive { get; set; }
    }
}
