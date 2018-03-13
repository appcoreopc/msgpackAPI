using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentHistory
    {
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
        public int Version { get; set; }
        public bool? Inactive { get; set; }
        public decimal? CouponAmount { get; set; }
        public int? SwapResetDay { get; set; }
        public bool? SwapNotionalExchange { get; set; }
        public bool? SwapDuplicate { get; set; }
        public string Collateralised { get; set; }
        public string SecurityType { get; set; }
        public bool? IsCls { get; set; }

        public Instrument Instrument { get; set; }
    }
}
