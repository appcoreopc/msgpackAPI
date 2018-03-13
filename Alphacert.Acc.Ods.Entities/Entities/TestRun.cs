using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestRun
    {
        public TestRun()
        {
            TestRunGroup = new HashSet<TestRunGroup>();
            TestRunItem = new HashSet<TestRunItem>();
        }

        public int TestRunId { get; set; }
        public int TestRunTypeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public int TestRunStatusId { get; set; }
        public int? TestStatusId { get; set; }
        public string ApprovedBy { get; set; }
        public string Comment { get; set; }
        public DateTime ValuationDate { get; set; }
        public DateTime? DateApproved { get; set; }
        public int? OverrideTestStatusId { get; set; }
        public bool? Approved { get; set; }
        public int? TestTypeId { get; set; }

        public TestStatus OverrideTestStatus { get; set; }
        public TestRunStatus TestRunStatus { get; set; }
        public TestRunType TestRunType { get; set; }
        public TestStatus TestStatus { get; set; }
        public TestType TestType { get; set; }
        public ICollection<TestRunGroup> TestRunGroup { get; set; }
        public ICollection<TestRunItem> TestRunItem { get; set; }
    }
}
