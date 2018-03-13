using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TradeStatus
    {
        public TradeStatus()
        {
            Trade = new HashSet<Trade>();
            TradeHistory = new HashSet<TradeHistory>();
        }

        public int TradeStatusId { get; set; }
        public string StatusCode { get; set; }
        public string Description { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<Trade> Trade { get; set; }
        public ICollection<TradeHistory> TradeHistory { get; set; }
    }
}
