using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Trade
    {
        public Trade()
        {
            AccprojectionTrades = new HashSet<AccprojectionTrades>();
            FundingAllocations = new HashSet<FundingAllocations>();
            TradeConfirmation = new HashSet<TradeConfirmation>();
            TradeConfirmationFx = new HashSet<TradeConfirmationFx>();
            TradeHistory = new HashSet<TradeHistory>();
        }

        public int TradeId { get; set; }
        public int TradeStatusId { get; set; }
        public int InstrumentId { get; set; }
        public int PortfolioId { get; set; }
        public int? TransactionTypeId { get; set; }
        public DateTime? TradeDate { get; set; }
        public decimal? BuyAmount { get; set; }
        public decimal? SellAmount { get; set; }
        public decimal? NumberOfShares { get; set; }
        public decimal? Price { get; set; }
        public DateTime? SettlementDate { get; set; }
        public int? BrokerId { get; set; }
        public decimal? BrokerageRate { get; set; }
        public string BrokerageUnits { get; set; }
        public decimal? FeesLocalCurrency { get; set; }
        public bool? SecurityLending { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal? StampDuty { get; set; }
        public string ExchangeCode { get; set; }
        public decimal? OtherCharges { get; set; }
        public bool? BulkTrade { get; set; }
        public int? SecurityLendingId { get; set; }
        public int? TradeGroupId { get; set; }
        public decimal? Yield { get; set; }
        public decimal? Margin { get; set; }
        public decimal? FaceValue { get; set; }
        public decimal? SettlementAmount { get; set; }
        public decimal? Interest { get; set; }
        public string Notes { get; set; }
        public DateTime? StartDate { get; set; }
        public string Comment { get; set; }
        public int? Instrument2Id { get; set; }
        public string SwapType { get; set; }
        public long? SwapDealNo { get; set; }
        public decimal? InterestAmountPaid { get; set; }
        public decimal? InterestAmountReceived { get; set; }
        public string TradeType { get; set; }
        public decimal? TotalConsideration { get; set; }
        public decimal? AdditionalCouponAmount { get; set; }
        public DateTime? AdditionalCouponDate { get; set; }
        public decimal? Accrued { get; set; }
        public decimal? UpFrontFee { get; set; }
        public decimal? CleanPrice { get; set; }
        public decimal? Fees { get; set; }
        public int? ReturnSecurityLendingId { get; set; }
        public int? TransactionId { get; set; }
        public int? Transaction2Id { get; set; }
        public int? OpenFfxid { get; set; }
        public bool? Reconciled { get; set; }
        public string InternalRefNumber { get; set; }
        public int? Units { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? FixedRate { get; set; }
        public bool? Inactive { get; set; }
        public int? Version { get; set; }
        public decimal? CloseOutAmount { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string OriginalSource { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
        public string LastModifiedBy { get; set; }
        public string ReasonForModification { get; set; }
        public string ReasonForCancellation { get; set; }
        public string Collateralised { get; set; }
        public string CloseOutCurrency { get; set; }
        public string CloseOutType { get; set; }
        public string BbeventReference { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? Commission { get; set; }
        public decimal? NetAmount { get; set; }
        public int? BboriginalTicketReference { get; set; }
        public int? BbtransNum { get; set; }

        public CounterParty Broker { get; set; }
        public Instrument Instrument { get; set; }
        public Instrument Instrument2 { get; set; }
        public OpenFfxposition OpenFfx { get; set; }
        public Portfolio Portfolio { get; set; }
        public TradeGroup TradeGroup { get; set; }
        public TradeStatus TradeStatus { get; set; }
        public Transaction Transaction { get; set; }
        public Transaction Transaction2 { get; set; }
        public TransactionType TransactionType { get; set; }
        public ICollection<AccprojectionTrades> AccprojectionTrades { get; set; }
        public ICollection<FundingAllocations> FundingAllocations { get; set; }
        public ICollection<TradeConfirmation> TradeConfirmation { get; set; }
        public ICollection<TradeConfirmationFx> TradeConfirmationFx { get; set; }
        public ICollection<TradeHistory> TradeHistory { get; set; }
    }
}
