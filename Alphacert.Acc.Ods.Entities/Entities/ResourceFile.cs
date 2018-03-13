using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ResourceFile
    {
        public ResourceFile()
        {
            ResourceFileVersion = new HashSet<ResourceFileVersion>();
        }

        public int ResourceFileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? InActive { get; set; }

        public ICollection<ResourceFileVersion> ResourceFileVersion { get; set; }
    }
}
