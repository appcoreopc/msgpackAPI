using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Status
    {
        public Status()
        {
            AccountingBudgetGroup = new HashSet<AccountingBudgetGroup>();
            AccprojectionApproval = new HashSet<AccprojectionApproval>();
            BenchmarkComponent = new HashSet<BenchmarkComponent>();
            JpmcashAdjustment = new HashSet<JpmcashAdjustment>();
            PerformanceHistory = new HashSet<PerformanceHistory>();
            PerformanceHistoryDetails = new HashSet<PerformanceHistoryDetails>();
            ReconciliationDefinitionRun = new HashSet<ReconciliationDefinitionRun>();
            ReconciliationRun = new HashSet<ReconciliationRun>();
            ReconciliationValidationRun = new HashSet<ReconciliationValidationRun>();
            Ssihistory = new HashSet<Ssihistory>();
            Test = new HashSet<Test>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<AccountingBudgetGroup> AccountingBudgetGroup { get; set; }
        public ICollection<AccprojectionApproval> AccprojectionApproval { get; set; }
        public ICollection<BenchmarkComponent> BenchmarkComponent { get; set; }
        public ICollection<JpmcashAdjustment> JpmcashAdjustment { get; set; }
        public ICollection<PerformanceHistory> PerformanceHistory { get; set; }
        public ICollection<PerformanceHistoryDetails> PerformanceHistoryDetails { get; set; }
        public ICollection<ReconciliationDefinitionRun> ReconciliationDefinitionRun { get; set; }
        public ICollection<ReconciliationRun> ReconciliationRun { get; set; }
        public ICollection<ReconciliationValidationRun> ReconciliationValidationRun { get; set; }
        public ICollection<Ssihistory> Ssihistory { get; set; }
        public ICollection<Test> Test { get; set; }
    }
}
