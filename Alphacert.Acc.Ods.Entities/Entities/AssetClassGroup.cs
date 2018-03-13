using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AssetClassGroup
    {
        public int AssetClassGroupId { get; set; }
        public string AssetClassGroupName { get; set; }
        public string AssetClassGroupDesc { get; set; }
        public bool? Inactive { get; set; }
    }
}
