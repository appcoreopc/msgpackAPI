using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class OpenFfxposition
    {
        public OpenFfxposition()
        {
            Trade = new HashSet<Trade>();
        }

        public int OpenFfxid { get; set; }
        public int PortfolioId { get; set; }
        public int InstrumentId { get; set; }
        public DateTime ValuationDate { get; set; }
        public DateTime ValuationRunDateTime { get; set; }
        public string PortfolioCurrencyCode { get; set; }
        public string HiportTransactionId { get; set; }
        public DateTime TradeDate { get; set; }
        public decimal? BuyNominal { get; set; }
        public decimal? SellNominal { get; set; }
        public decimal? BuyNominalBase { get; set; }
        public decimal? SellNominalBase { get; set; }
        public decimal? ContractFwdRate { get; set; }
        public decimal? CurrentFwdRate { get; set; }
        public decimal? UnrealisedFxgainLoss { get; set; }
        public string ClientTradeId { get; set; }
        public decimal? ExchangeRateBuyToPortfolio { get; set; }
        public string ExchBuyToPfMorDflag { get; set; }
        public decimal? ExchangeRateSellToPortfolio { get; set; }
        public string ExchSellToPfMorDflag { get; set; }
        public int LoadId { get; set; }
        public int BatchId { get; set; }
        public bool? Inactive { get; set; }
        public int? CounterPartyId { get; set; }
        public DateTime? MaturityDate { get; set; }

        public CounterParty CounterParty { get; set; }
        public InstrumentPortfolio InstrumentPortfolio { get; set; }
        public ICollection<Trade> Trade { get; set; }
    }
}
