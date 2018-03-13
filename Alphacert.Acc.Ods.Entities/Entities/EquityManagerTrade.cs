using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class EquityManagerTrade
    {
        public int EquityMgrTradeId { get; set; }
        public DateTime? DealDate { get; set; }
        public int? PortfolioId { get; set; }
        public string Broker { get; set; }
        public string BuySell { get; set; }
        public decimal? Quantity { get; set; }
        public string Stock { get; set; }
        public decimal? Price { get; set; }
        public decimal? BrokerageRate { get; set; }
        public decimal? BrokerageCost { get; set; }
        public decimal? TransactionValue { get; set; }
        public int BatchId { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
