using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TradeRelationshipType
    {
        public TradeRelationshipType()
        {
            TradeGroup = new HashSet<TradeGroup>();
        }

        public int TradeRelationshipTypeId { get; set; }
        public string TradeRelationshipDesc { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<TradeGroup> TradeGroup { get; set; }
    }
}
