using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AccountingBudgetGroup
    {
        public AccountingBudgetGroup()
        {
            AccountingBudget = new HashSet<AccountingBudget>();
        }

        public int AccountingBudgetGroupId { get; set; }
        public string Name { get; set; }
        public int StatusId { get; set; }
        public int Year { get; set; }
        public DateTime LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string ApprovedBy { get; set; }
        public bool? Inactive { get; set; }

        public Status Status { get; set; }
        public ICollection<AccountingBudget> AccountingBudget { get; set; }
    }
}
