using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestRunStatus
    {
        public TestRunStatus()
        {
            TestRun = new HashSet<TestRun>();
            TestRunGroup = new HashSet<TestRunGroup>();
            TestRunItem = new HashSet<TestRunItem>();
        }

        public int TestRunStatusId { get; set; }
        public string TestRunStatusDescription { get; set; }
        public bool? Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<TestRun> TestRun { get; set; }
        public ICollection<TestRunGroup> TestRunGroup { get; set; }
        public ICollection<TestRunItem> TestRunItem { get; set; }
    }
}
