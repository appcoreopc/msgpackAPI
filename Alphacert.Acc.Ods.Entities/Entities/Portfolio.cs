using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Portfolio
    {
        public Portfolio()
        {
            AccprojectionAdjustment = new HashSet<AccprojectionAdjustment>();
            AccprojectionVerificationRule = new HashSet<AccprojectionVerificationRule>();
            AdditionalBenchmarkInstrument = new HashSet<AdditionalBenchmarkInstrument>();
            AssetAllocationFromPortfolio = new HashSet<AssetAllocation>();
            AssetAllocationToPortfolio = new HashSet<AssetAllocation>();
            BenchmarkComponent = new HashSet<BenchmarkComponent>();
            ComplianceAuthorisationRule = new HashSet<ComplianceAuthorisationRule>();
            CustodianGl = new HashSet<CustodianGl>();
            CustodianGlhistory = new HashSet<CustodianGlhistory>();
            EquityManagerPosition = new HashSet<EquityManagerPosition>();
            EquityManagerTrade = new HashSet<EquityManagerTrade>();
            Fimanager = new HashSet<Fimanager>();
            FutureAccount = new HashSet<FutureAccount>();
            FuturePosition = new HashSet<FuturePosition>();
            FutureTrade = new HashSet<FutureTrade>();
            FuturesBalance = new HashSet<FuturesBalance>();
            InstrumentPortfolio = new HashSet<InstrumentPortfolio>();
            JpmcashAdjustment = new HashSet<JpmcashAdjustment>();
            JpmcashProjection = new HashSet<JpmcashProjection>();
            Jpmcustody = new HashSet<Jpmcustody>();
            JpmpostedCashBalance = new HashSet<JpmpostedCashBalance>();
            JpmpostedCashDetail = new HashSet<JpmpostedCashDetail>();
            JpmpostedCashSummary = new HashSet<JpmpostedCashSummary>();
            ManagerHolding = new HashSet<ManagerHolding>();
            OnCallCashAssignment = new HashSet<OnCallCashAssignment>();
            OracleGl = new HashSet<OracleGl>();
            PerformanceHistoryDetails = new HashSet<PerformanceHistoryDetails>();
            PortfolioAssetClass = new HashSet<PortfolioAssetClass>();
            PortfolioComponent = new HashSet<PortfolioComponent>();
            Trade = new HashSet<Trade>();
        }

        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string CustodianCode { get; set; }
        public string Custodian { get; set; }
        public string AccfundCode { get; set; }
        public string Managed { get; set; }
        public string Analysis { get; set; }
        public string CustodyAccount { get; set; }
        public bool? Inactive { get; set; }
        public bool? Closed { get; set; }
        public DateTime? PortfolioStartDate { get; set; }
        public DateTime? PortfolioEndDate { get; set; }

        public BbaimaccountStatus BbaimaccountStatus { get; set; }
        public ICollection<AccprojectionAdjustment> AccprojectionAdjustment { get; set; }
        public ICollection<AccprojectionVerificationRule> AccprojectionVerificationRule { get; set; }
        public ICollection<AdditionalBenchmarkInstrument> AdditionalBenchmarkInstrument { get; set; }
        public ICollection<AssetAllocation> AssetAllocationFromPortfolio { get; set; }
        public ICollection<AssetAllocation> AssetAllocationToPortfolio { get; set; }
        public ICollection<BenchmarkComponent> BenchmarkComponent { get; set; }
        public ICollection<ComplianceAuthorisationRule> ComplianceAuthorisationRule { get; set; }
        public ICollection<CustodianGl> CustodianGl { get; set; }
        public ICollection<CustodianGlhistory> CustodianGlhistory { get; set; }
        public ICollection<EquityManagerPosition> EquityManagerPosition { get; set; }
        public ICollection<EquityManagerTrade> EquityManagerTrade { get; set; }
        public ICollection<Fimanager> Fimanager { get; set; }
        public ICollection<FutureAccount> FutureAccount { get; set; }
        public ICollection<FuturePosition> FuturePosition { get; set; }
        public ICollection<FutureTrade> FutureTrade { get; set; }
        public ICollection<FuturesBalance> FuturesBalance { get; set; }
        public ICollection<InstrumentPortfolio> InstrumentPortfolio { get; set; }
        public ICollection<JpmcashAdjustment> JpmcashAdjustment { get; set; }
        public ICollection<JpmcashProjection> JpmcashProjection { get; set; }
        public ICollection<Jpmcustody> Jpmcustody { get; set; }
        public ICollection<JpmpostedCashBalance> JpmpostedCashBalance { get; set; }
        public ICollection<JpmpostedCashDetail> JpmpostedCashDetail { get; set; }
        public ICollection<JpmpostedCashSummary> JpmpostedCashSummary { get; set; }
        public ICollection<ManagerHolding> ManagerHolding { get; set; }
        public ICollection<OnCallCashAssignment> OnCallCashAssignment { get; set; }
        public ICollection<OracleGl> OracleGl { get; set; }
        public ICollection<PerformanceHistoryDetails> PerformanceHistoryDetails { get; set; }
        public ICollection<PortfolioAssetClass> PortfolioAssetClass { get; set; }
        public ICollection<PortfolioComponent> PortfolioComponent { get; set; }
        public ICollection<Trade> Trade { get; set; }
    }
}
