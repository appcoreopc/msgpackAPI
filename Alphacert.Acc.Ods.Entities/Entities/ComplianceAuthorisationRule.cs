using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ComplianceAuthorisationRule
    {
        public int ComplianceAuthorisationRuleId { get; set; }
        public int PortfolioId { get; set; }
        public int? InstrumentTypeId { get; set; }
        public int? InstrumentSubTypeId { get; set; }
        public string Sedol { get; set; }
        public string Isin { get; set; }
        public int? ExchangeId { get; set; }
        public string Currency { get; set; }
        public bool? Exclude { get; set; }
        public bool? Inactive { get; set; }

        public Exchange Exchange { get; set; }
        public InstrumentSubType InstrumentSubType { get; set; }
        public InstrumentType InstrumentType { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
