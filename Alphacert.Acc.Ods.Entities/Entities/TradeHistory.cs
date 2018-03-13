using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TradeHistory
    {
        public int TradeHistoryId { get; set; }
        public DateTime WhenCreated { get; set; }
        public string WhoChanged { get; set; }
        public int? TradeStatusId { get; set; }
        public int? TradeId { get; set; }
        public bool? Inactive { get; set; }

        public Trade Trade { get; set; }
        public TradeStatus TradeStatus { get; set; }
    }
}
