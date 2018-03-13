using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class EntityType
    {
        public EntityType()
        {
            EntityLinkFromEntityType = new HashSet<EntityLink>();
            EntityLinkToEntityType = new HashSet<EntityLink>();
        }

        public int EntityTypeId { get; set; }
        public string EntityTypeName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? InActive { get; set; }

        public ICollection<EntityLink> EntityLinkFromEntityType { get; set; }
        public ICollection<EntityLink> EntityLinkToEntityType { get; set; }
    }
}
