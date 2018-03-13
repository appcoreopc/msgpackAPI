using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Ifrshistory
    {
        public long Identity { get; set; }
        public int BatchId { get; set; }
        public int LoadId { get; set; }
        public bool? Inactive { get; set; }
        public DateTime? ValuationDate { get; set; }
        public string PortfolioCode { get; set; }
        public string Sedol { get; set; }
        public decimal? UnitHolding { get; set; }
        public decimal? LocalPrice { get; set; }
        public string Ccy { get; set; }
        public decimal? GrossMarketValue { get; set; }
        public decimal? GrossUnrealizedProfitLoss { get; set; }
        public decimal? LocalValue { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? CapitalUnrealizedProfitLoss { get; set; }
        public decimal? NetUnrealizedProfitLoss { get; set; }
        public int? InstrumentId { get; set; }
        public int? PortfolioId { get; set; }

        public InstrumentPortfolio InstrumentPortfolio { get; set; }
    }
}
