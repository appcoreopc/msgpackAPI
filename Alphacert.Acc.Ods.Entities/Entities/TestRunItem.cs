using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestRunItem
    {
        public TestRunItem()
        {
            TestRunItemStep = new HashSet<TestRunItemStep>();
        }

        public int TestRunItemId { get; set; }
        public int TestRunId { get; set; }
        public int Sequence { get; set; }
        public int? TestGroupId { get; set; }
        public int? TestId { get; set; }
        public bool? Inactive { get; set; }
        public DateTime DateCreated { get; set; }
        public int? TestRunStatusId { get; set; }
        public int? TestStatusId { get; set; }
        public int TestRunGroupId { get; set; }
        public string Comment { get; set; }
        public DateTime? DateApproved { get; set; }
        public int? OverrideTestStatusId { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public int? RunTimeMilliseconds { get; set; }
        public DateTime? ExecutionDate { get; set; }

        public TestStatus OverrideTestStatus { get; set; }
        public Test Test { get; set; }
        public TestGroup TestGroup { get; set; }
        public TestRun TestRun { get; set; }
        public TestRunGroup TestRunGroup { get; set; }
        public TestRunStatus TestRunStatus { get; set; }
        public TestStatus TestStatus { get; set; }
        public ICollection<TestRunItemStep> TestRunItemStep { get; set; }
    }
}
