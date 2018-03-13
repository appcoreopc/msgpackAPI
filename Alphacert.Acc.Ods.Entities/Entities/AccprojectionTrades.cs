using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AccprojectionTrades
    {
        public int AccprojectionTradesId { get; set; }
        public int TradeId { get; set; }
        public DateTime PostedDate { get; set; }

        public Trade Trade { get; set; }
    }
}
