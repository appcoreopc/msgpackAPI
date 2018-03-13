using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Ssihistory
    {
        public int SsihistoryId { get; set; }
        public DateTime? WhenCreated { get; set; }
        public string WhoChanged { get; set; }
        public int? StatusId { get; set; }
        public string Comments { get; set; }
        public int? Ssiid { get; set; }
        public int? Psetid { get; set; }
        public string CustodianId { get; set; }
        public int CounterPartyId { get; set; }
        public int InstrumentTypeId { get; set; }
        public string ClearCode { get; set; }
        public int? JpmsecLendingId { get; set; }
        public string ExecutingBrokerPrimary { get; set; }
        public string ExecutingBrokerSecondary { get; set; }
        public string ExecutingBrokerTertiary { get; set; }
        public string ClearingBrokerPrimary { get; set; }
        public string ClearingBrokerSecondary { get; set; }
        public string ClearingBrokerTertiary { get; set; }
        public string SpecialAccountNumber { get; set; }
        public string ExecutingBrokerNumber { get; set; }
        public string BeneficiaryAccountNumber { get; set; }
        public string BeneficiaryAccountName { get; set; }
        public string BeneficiaryBankName { get; set; }
        public string BeneficiaryBankBic { get; set; }
        public string IntermediaryName { get; set; }
        public string IntermediaryBic { get; set; }
        public string UltimateBeneficiaryBic { get; set; }
        public bool? Inactive { get; set; }

        public CounterParty CounterParty { get; set; }
        public InstrumentType InstrumentType { get; set; }
        public PlaceOfSettlement Pset { get; set; }
        public Ssi Ssi { get; set; }
        public Status Status { get; set; }
    }
}
