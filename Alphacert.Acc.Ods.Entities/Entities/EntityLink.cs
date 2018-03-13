using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class EntityLink
    {
        public int EntityLinkId { get; set; }
        public int? FromEntityTypeId { get; set; }
        public int? FromEntityId { get; set; }
        public int? ToEntityTypeId { get; set; }
        public int? ToEntityId { get; set; }
        public int? EntityLinkTypeId { get; set; }
        public string Payload { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? InActive { get; set; }

        public EntityLinkType EntityLinkType { get; set; }
        public EntityType FromEntityType { get; set; }
        public EntityType ToEntityType { get; set; }
    }
}
