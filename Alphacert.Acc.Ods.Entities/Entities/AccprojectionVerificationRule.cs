using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AccprojectionVerificationRule
    {
        public int AccprojectionVerificationRuleId { get; set; }
        public int PortfolioId { get; set; }
        public string Currency { get; set; }
        public string RuleType { get; set; }
        public decimal Value { get; set; }
        public bool? Inactive { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
