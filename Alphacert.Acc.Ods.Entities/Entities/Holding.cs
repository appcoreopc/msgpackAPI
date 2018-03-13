using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Holding
    {
        public Holding()
        {
            AccadjustmentHistory = new HashSet<AccadjustmentHistory>();
        }

        public int HoldingId { get; set; }
        public int PortfolioId { get; set; }
        public int InstrumentId { get; set; }
        public decimal? AccruedInterest { get; set; }
        public string AmortisationInPeriod { get; set; }
        public decimal? AmortisedValue { get; set; }
        public int? BatchId { get; set; }
        public decimal? BookCost { get; set; }
        public decimal? BookCostBase { get; set; }
        public decimal? Duration { get; set; }
        public string EarnedIncomeInPeriod { get; set; }
        public decimal? ExchangeRateLocalToPortfolio { get; set; }
        public decimal? ExchangeRateLocalToUsd { get; set; }
        public decimal? ExchangeRatePortfolioToUsd { get; set; }
        public string ExchLclToPfMorDflag { get; set; }
        public string ExchLclToUsdmorDflag { get; set; }
        public string ExchPfToUsdmorDflag { get; set; }
        public string FuturesInitialMargin { get; set; }
        public decimal? FuturesVariationMargin { get; set; }
        public decimal? HoldingsCash { get; set; }
        public decimal? HoldingsCashBase { get; set; }
        public long? StagingRowId { get; set; }
        public decimal? IncomeAccrued { get; set; }
        public int? LoadId { get; set; }
        public decimal? MarketValue { get; set; }
        public decimal? MarketValueBase { get; set; }
        public decimal? OriginalCost { get; set; }
        public string OriginalFaceValue { get; set; }
        public decimal? Payables { get; set; }
        public decimal? Price { get; set; }
        public decimal? Receivables { get; set; }
        public decimal? UnitHolding { get; set; }
        public decimal? UnrealisedProfitOrLoss { get; set; }
        public DateTime ValuationDate { get; set; }
        public DateTime? ValuationRunDateTime { get; set; }
        public bool? Inactive { get; set; }
        public decimal? BaseFairMarketValue { get; set; }
        public decimal? BaseHistoricCost { get; set; }
        public decimal? BaseMarketValue { get; set; }
        public decimal? TotalMarketValueBaseIfrs { get; set; }
        public decimal? BaseTotalValue { get; set; }
        public decimal? PriceLocalIfrs { get; set; }
        public decimal? TotalMarketValueLocalIfrs { get; set; }
        public string PortfolioCurrencyCode { get; set; }
        public decimal? PricingFactor { get; set; }
        public string PricingType { get; set; }
        public DateTime? SecurityMaturityDate { get; set; }
        public decimal? AccadjustmentMarketValueBase { get; set; }
        public decimal? AccadjustmentDiscount { get; set; }
        public decimal? AccadjustmentIfrs { get; set; }
        public int? AccadjustmentStatusId { get; set; }
        public decimal? AccruedIncomeBase { get; set; }
        public decimal? AdjustedValueBase { get; set; }
        public decimal? CapitalValueBase { get; set; }
        public decimal? CapitalValueLocal { get; set; }
        public decimal? DisposalCostBase { get; set; }
        public decimal? EffectiveExposureLocal { get; set; }
        public decimal? RealizableBaseValue { get; set; }
        public decimal? RealizableLocalValue { get; set; }
        public decimal? PercentageOfHoldings { get; set; }
        public decimal? EffectiveExposureBase { get; set; }
        public decimal? UnrealisedProfitLossBaseIfrs { get; set; }
        public decimal? MarketValueBaseIfrs { get; set; }
        public decimal? NtAccruedIncomeBase { get; set; }
        public decimal? NtTotalMarketValueBaseIfrs { get; set; }
        public decimal? NtMarketValueBase { get; set; }
        public decimal? NtBaseIncomeReceivable { get; set; }

        public AccadjustmentStatus AccadjustmentStatus { get; set; }
        public InstrumentPortfolio InstrumentPortfolio { get; set; }
        public ICollection<AccadjustmentHistory> AccadjustmentHistory { get; set; }
    }
}
