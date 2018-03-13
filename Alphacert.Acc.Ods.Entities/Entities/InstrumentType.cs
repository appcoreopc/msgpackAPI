using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentType
    {
        public InstrumentType()
        {
            AutoClassificationMapping = new HashSet<AutoClassificationMapping>();
            BbaimsubTypeMapping = new HashSet<BbaimsubTypeMapping>();
            ComplianceAuthorisationRule = new HashSet<ComplianceAuthorisationRule>();
            EquityManagerPosition = new HashSet<EquityManagerPosition>();
            FinancialCalendar = new HashSet<FinancialCalendar>();
            Instrument = new HashSet<Instrument>();
            InstrumentGroup = new HashSet<InstrumentGroup>();
            InstrumentSubType = new HashSet<InstrumentSubType>();
            InstrumentTypeTransactionType = new HashSet<InstrumentTypeTransactionType>();
            JpmsubTypeMapping = new HashSet<JpmsubTypeMapping>();
            Ssi = new HashSet<Ssi>();
            Ssihistory = new HashSet<Ssihistory>();
            TypeSettlementPlace = new HashSet<TypeSettlementPlace>();
        }

        public int InstrumentTypeId { get; set; }
        public string InstrumentTypeDesc { get; set; }
        public bool? CanTrade { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<AutoClassificationMapping> AutoClassificationMapping { get; set; }
        public ICollection<BbaimsubTypeMapping> BbaimsubTypeMapping { get; set; }
        public ICollection<ComplianceAuthorisationRule> ComplianceAuthorisationRule { get; set; }
        public ICollection<EquityManagerPosition> EquityManagerPosition { get; set; }
        public ICollection<FinancialCalendar> FinancialCalendar { get; set; }
        public ICollection<Instrument> Instrument { get; set; }
        public ICollection<InstrumentGroup> InstrumentGroup { get; set; }
        public ICollection<InstrumentSubType> InstrumentSubType { get; set; }
        public ICollection<InstrumentTypeTransactionType> InstrumentTypeTransactionType { get; set; }
        public ICollection<JpmsubTypeMapping> JpmsubTypeMapping { get; set; }
        public ICollection<Ssi> Ssi { get; set; }
        public ICollection<Ssihistory> Ssihistory { get; set; }
        public ICollection<TypeSettlementPlace> TypeSettlementPlace { get; set; }
    }
}
