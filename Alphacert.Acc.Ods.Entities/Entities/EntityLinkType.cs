using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class EntityLinkType
    {
        public EntityLinkType()
        {
            EntityLink = new HashSet<EntityLink>();
        }

        public int EntityLinkTypeId { get; set; }
        public string EntityLinkTypeName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? InActive { get; set; }

        public ICollection<EntityLink> EntityLink { get; set; }
    }
}
