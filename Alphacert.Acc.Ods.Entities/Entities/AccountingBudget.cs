using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AccountingBudget
    {
        public int AccountingBudgetId { get; set; }
        public int AccountingBudgetGroupId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Value { get; set; }
        public bool? Inactive { get; set; }

        public AccountingBudgetGroup AccountingBudgetGroup { get; set; }
    }
}
