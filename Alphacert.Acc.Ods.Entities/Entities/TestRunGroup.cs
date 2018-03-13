using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestRunGroup
    {
        public TestRunGroup()
        {
            InverseParentTestRunGroup = new HashSet<TestRunGroup>();
            TestRunItem = new HashSet<TestRunItem>();
        }

        public int TestRunGroupId { get; set; }
        public int TestGroupId { get; set; }
        public bool? Inactive { get; set; }
        public DateTime DateCreated { get; set; }
        public int? ParentTestRunGroupId { get; set; }
        public int TestRunId { get; set; }
        public int TestRunStatusId { get; set; }
        public int? TestStatusId { get; set; }
        public DateTime? DateApproved { get; set; }
        public int? OverrideTestStatusId { get; set; }
        public bool? Approved { get; set; }
        public string Comment { get; set; }
        public string ApprovedBy { get; set; }

        public TestStatus OverrideTestStatus { get; set; }
        public TestRunGroup ParentTestRunGroup { get; set; }
        public TestGroup TestGroup { get; set; }
        public TestRun TestRun { get; set; }
        public TestRunStatus TestRunStatus { get; set; }
        public TestStatus TestStatus { get; set; }
        public ICollection<TestRunGroup> InverseParentTestRunGroup { get; set; }
        public ICollection<TestRunItem> TestRunItem { get; set; }
    }
}
