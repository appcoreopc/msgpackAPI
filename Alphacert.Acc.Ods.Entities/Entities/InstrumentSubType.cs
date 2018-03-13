using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentSubType
    {
        public InstrumentSubType()
        {
            AutoClassificationMapping = new HashSet<AutoClassificationMapping>();
            BbaimsubTypeMapping = new HashSet<BbaimsubTypeMapping>();
            ComplianceAuthorisationRule = new HashSet<ComplianceAuthorisationRule>();
            Instrument = new HashSet<Instrument>();
            InstrumentGroup = new HashSet<InstrumentGroup>();
            JpmsubTypeMapping = new HashSet<JpmsubTypeMapping>();
            Sshentity = new HashSet<Sshentity>();
        }

        public int InstrumentSubTypeId { get; set; }
        public int InstrumentTypeId { get; set; }
        public string InstrumentSubTypeDesc { get; set; }
        public string InstrumentSubTypeCode { get; set; }
        public bool? CanTrade { get; set; }
        public bool? Inactive { get; set; }
        public bool? IsDerivative { get; set; }
        public bool? IsOtherDerivative { get; set; }

        public InstrumentType InstrumentType { get; set; }
        public ICollection<AutoClassificationMapping> AutoClassificationMapping { get; set; }
        public ICollection<BbaimsubTypeMapping> BbaimsubTypeMapping { get; set; }
        public ICollection<ComplianceAuthorisationRule> ComplianceAuthorisationRule { get; set; }
        public ICollection<Instrument> Instrument { get; set; }
        public ICollection<InstrumentGroup> InstrumentGroup { get; set; }
        public ICollection<JpmsubTypeMapping> JpmsubTypeMapping { get; set; }
        public ICollection<Sshentity> Sshentity { get; set; }
    }
}
