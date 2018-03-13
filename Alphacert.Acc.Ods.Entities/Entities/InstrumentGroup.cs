using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentGroup
    {
        public InstrumentGroup()
        {
            InstrumentGroupProperty = new HashSet<InstrumentGroupProperty>();
        }

        public int InstrumentGroupId { get; set; }
        public int InstrumentGroupTypeId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string CompanyName { get; set; }
        public string InstrumentGroupDescription { get; set; }
        public int? InstrumentId { get; set; }
        public int? InstrumentTypeId { get; set; }
        public int? InstrumentSubTypeId { get; set; }
        public string Isin { get; set; }
        public string Sedol { get; set; }
        public string Cusip { get; set; }
        public int? JpmsecurityId { get; set; }
        public string NtsecurityId { get; set; }
        public string Ticker { get; set; }
        public int? IssuerId { get; set; }
        public bool? NonCompliant { get; set; }
        public string GicssubIndustry { get; set; }
        public bool? Inactive { get; set; }
        public DateTime? DateCreated { get; set; }
        public string PropertyXml { get; set; }
        public DateTime? EffectiveTillDate { get; set; }

        public Instrument Instrument { get; set; }
        public InstrumentGroupType InstrumentGroupType { get; set; }
        public InstrumentSubType InstrumentSubType { get; set; }
        public InstrumentType InstrumentType { get; set; }
        public ICollection<InstrumentGroupProperty> InstrumentGroupProperty { get; set; }
    }
}
