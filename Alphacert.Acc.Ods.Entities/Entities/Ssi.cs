using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Ssi
    {
        public Ssi()
        {
            Ssihistory = new HashSet<Ssihistory>();
        }

        public int Ssiid { get; set; }
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
        public ICollection<Ssihistory> Ssihistory { get; set; }
    }
}
