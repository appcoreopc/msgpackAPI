using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ResourceFileVersion
    {
        public int ResourceFileVersionId { get; set; }
        public int ResourceFileId { get; set; }
        public string Path { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public string Comment { get; set; }
        public string ContentType { get; set; }
        public bool? InActive { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }

        public ResourceFile ResourceFile { get; set; }
    }
}
