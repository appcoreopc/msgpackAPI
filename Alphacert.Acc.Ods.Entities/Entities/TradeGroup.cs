using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TradeGroup
    {
        public TradeGroup()
        {
            Trade = new HashSet<Trade>();
        }

        public int TradeGroupId { get; set; }
        public int? TradeRelationshipTypeId { get; set; }
        public bool? Inactive { get; set; }

        public TradeRelationshipType TradeRelationshipType { get; set; }
        public ICollection<Trade> Trade { get; set; }
    }
}
