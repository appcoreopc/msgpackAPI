using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AccprojectionAdjustment
    {
        public int AccprojectionAdjustmentId { get; set; }
        public int PortfolioId { get; set; }
        public int? InstrumentId { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime AdjustmentDate { get; set; }
        public DateTime? ProjectedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
        public string Comment { get; set; }
        public string TransactionType { get; set; }
        public string ClientRef { get; set; }
        public string UltimateBeneficiary { get; set; }
        public string UltimateBeneficiaryBic { get; set; }
        public string UltimateBeneficiaryAccount { get; set; }
        public string BeneficiaryBankBic { get; set; }
        public string NationalClearingCode { get; set; }
        public bool? Inactive { get; set; }
        public string CounterPartyName { get; set; }

        public Instrument Instrument { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
