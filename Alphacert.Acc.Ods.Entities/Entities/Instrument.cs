using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Instrument
    {
        public Instrument()
        {
            AccprojectionAdjustment = new HashSet<AccprojectionAdjustment>();
            AdditionalBenchmarkInstrument = new HashSet<AdditionalBenchmarkInstrument>();
            BenchmarkComponentDetail = new HashSet<BenchmarkComponentDetail>();
            DiscountFactors = new HashSet<DiscountFactors>();
            Fimanager = new HashSet<Fimanager>();
            FuturePosition = new HashSet<FuturePosition>();
            FutureTrade = new HashSet<FutureTrade>();
            FuturesBalance = new HashSet<FuturesBalance>();
            InstrumentClassificationHistory = new HashSet<InstrumentClassificationHistory>();
            InstrumentCouponHistory = new HashSet<InstrumentCouponHistory>();
            InstrumentCreditRating = new HashSet<InstrumentCreditRating>();
            InstrumentGroup = new HashSet<InstrumentGroup>();
            InstrumentHistory = new HashSet<InstrumentHistory>();
            InstrumentMarketDataBenchmarkInstrument = new HashSet<InstrumentMarketData>();
            InstrumentMarketDataInstrument = new HashSet<InstrumentMarketData>();
            InstrumentPortfolio = new HashSet<InstrumentPortfolio>();
            InstrumentRelationshipPrimaryInstrument = new HashSet<InstrumentRelationship>();
            InstrumentRelationshipRelatedInstrument = new HashSet<InstrumentRelationship>();
            InverseInstrumentParent = new HashSet<Instrument>();
            Jpmcustody = new HashSet<Jpmcustody>();
            ManagerHolding = new HashSet<ManagerHolding>();
            OnCallCashAssignment = new HashSet<OnCallCashAssignment>();
            Sshentity = new HashSet<Sshentity>();
            TradeInstrument = new HashSet<Trade>();
            TradeInstrument2 = new HashSet<Trade>();
            TransactionLeg = new HashSet<TransactionLeg>();
        }

        public int InstrumentId { get; set; }
        public int? InstrumentParentId { get; set; }
        public int? IssuerId { get; set; }
        public int? InstrumentSubTypeId { get; set; }
        public string Isin { get; set; }
        public string Sedol { get; set; }
        public string Cusip { get; set; }
        public string JpmsecurityId { get; set; }
        public string NtsecurityId { get; set; }
        public string Ticker { get; set; }
        public string CustodianIdentifier { get; set; }
        public string InstrumentName { get; set; }
        public string InstrumentInternalName { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public bool? GovtGuaranteed { get; set; }
        public bool? IsSubordinated { get; set; }
        public bool? IsSenior { get; set; }
        public bool? IsUnsecured { get; set; }
        public string Exchange { get; set; }
        public string SharesOnIssue { get; set; }
        public string SharesOutstanding { get; set; }
        public string Currency { get; set; }
        public string CountryOfIssue { get; set; }
        public string Coupon { get; set; }
        public string WhoLastChanged { get; set; }
        public DateTime? WhenLastChanged { get; set; }
        public string JpmsecurityCategoryCode { get; set; }
        public string JpmsecurityCategoryTypeCode { get; set; }
        public string BrokerName { get; set; }
        public string BuyCurrencyCode { get; set; }
        public string SellCurrencyCode { get; set; }
        public int? InstrumentTypeId { get; set; }
        public string InternalReferenceNumber { get; set; }
        public int? CounterPartyId { get; set; }
        public string NtcategoryCode { get; set; }
        public string NtsubCategoryCode { get; set; }
        public string SwapType { get; set; }
        public string SwapFrequency { get; set; }
        public DateTime? StartDate { get; set; }
        public string SwapConvention { get; set; }
        public DateTime? SwapNextPayDate { get; set; }
        public string SwapDayCount { get; set; }
        public string SwapFixingName { get; set; }
        public string SwapHolidayList { get; set; }
        public decimal? NotionalValue { get; set; }
        public bool? PrincipalAdjusting { get; set; }
        public string SwapLegType { get; set; }
        public decimal? Margin { get; set; }
        public decimal? Term { get; set; }
        public decimal? RepoInterest { get; set; }
        public bool? SwapMonthEndConvention { get; set; }
        public int Version { get; set; }
        public decimal? ContractSize { get; set; }
        public DateTime? FutureExpiryDate { get; set; }
        public int? InitialMargin { get; set; }
        public string CouponType { get; set; }
        public decimal? Strike { get; set; }
        public string CallPut { get; set; }
        public int? CouponFrequency { get; set; }
        public bool? InActive { get; set; }
        public int? ExchangeId { get; set; }
        public bool? VotingRights { get; set; }
        public bool? AuthorisedRepo { get; set; }
        public string ComplianceComment { get; set; }
        public bool? IsRestricted { get; set; }
        public string BloombergRef { get; set; }
        public int? GuarantorIssuerId { get; set; }
        public bool? Locked { get; set; }
        public DateTime? WhenCreated { get; set; }
        public int? ProviderDataSourceId { get; set; }
        public string CollateralType { get; set; }
        public DateTime? InvestmentCommitteeApprovedDate { get; set; }
        public bool? ListedFlag { get; set; }
        public DateTime? ExpectedListingDate { get; set; }
        public string Glgroup { get; set; }
        public string JpmsectorLevel1 { get; set; }
        public string JpmsectorLevel2 { get; set; }
        public string JpmsectorLevel3 { get; set; }
        public string JpmsectorLevel4 { get; set; }
        public string JpmsectorLevel5 { get; set; }
        public string Gldescription { get; set; }
        public DateTime? InitialInvestmentDate { get; set; }
        public bool? MandatoryConvertibleFlag { get; set; }
        public decimal? CouponAmount { get; set; }
        public string FuturesMarket { get; set; }
        public int? SwapResetDay { get; set; }
        public string Rimescountry { get; set; }
        public bool? SwapNotionalExchange { get; set; }
        public bool? SwapDuplicate { get; set; }
        public string Collateralised { get; set; }
        public string SecurityType { get; set; }
        public bool? IsCls { get; set; }
        public string Gics { get; set; }
        public string IdBbUnique { get; set; }
        public string BbIdentifier { get; set; }

        public CounterParty CounterParty { get; set; }
        public Exchange ExchangeNavigation { get; set; }
        public Issuer GuarantorIssuer { get; set; }
        public Instrument InstrumentParent { get; set; }
        public InstrumentSubType InstrumentSubType { get; set; }
        public InstrumentType InstrumentType { get; set; }
        public Issuer Issuer { get; set; }
        public ProviderDataSource ProviderDataSource { get; set; }
        public ICollection<AccprojectionAdjustment> AccprojectionAdjustment { get; set; }
        public ICollection<AdditionalBenchmarkInstrument> AdditionalBenchmarkInstrument { get; set; }
        public ICollection<BenchmarkComponentDetail> BenchmarkComponentDetail { get; set; }
        public ICollection<DiscountFactors> DiscountFactors { get; set; }
        public ICollection<Fimanager> Fimanager { get; set; }
        public ICollection<FuturePosition> FuturePosition { get; set; }
        public ICollection<FutureTrade> FutureTrade { get; set; }
        public ICollection<FuturesBalance> FuturesBalance { get; set; }
        public ICollection<InstrumentClassificationHistory> InstrumentClassificationHistory { get; set; }
        public ICollection<InstrumentCouponHistory> InstrumentCouponHistory { get; set; }
        public ICollection<InstrumentCreditRating> InstrumentCreditRating { get; set; }
        public ICollection<InstrumentGroup> InstrumentGroup { get; set; }
        public ICollection<InstrumentHistory> InstrumentHistory { get; set; }
        public ICollection<InstrumentMarketData> InstrumentMarketDataBenchmarkInstrument { get; set; }
        public ICollection<InstrumentMarketData> InstrumentMarketDataInstrument { get; set; }
        public ICollection<InstrumentPortfolio> InstrumentPortfolio { get; set; }
        public ICollection<InstrumentRelationship> InstrumentRelationshipPrimaryInstrument { get; set; }
        public ICollection<InstrumentRelationship> InstrumentRelationshipRelatedInstrument { get; set; }
        public ICollection<Instrument> InverseInstrumentParent { get; set; }
        public ICollection<Jpmcustody> Jpmcustody { get; set; }
        public ICollection<ManagerHolding> ManagerHolding { get; set; }
        public ICollection<OnCallCashAssignment> OnCallCashAssignment { get; set; }
        public ICollection<Sshentity> Sshentity { get; set; }
        public ICollection<Trade> TradeInstrument { get; set; }
        public ICollection<Trade> TradeInstrument2 { get; set; }
        public ICollection<TransactionLeg> TransactionLeg { get; set; }
    }
}
