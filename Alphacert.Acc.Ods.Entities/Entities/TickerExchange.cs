using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TickerExchange
    {
        public string TickerExchangeCode { get; set; }
        public int ExchangeId { get; set; }

        public Exchange Exchange { get; set; }
    }
}
