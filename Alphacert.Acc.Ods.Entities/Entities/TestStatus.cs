using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestStatus
    {
        public TestStatus()
        {
            TestRange = new HashSet<TestRange>();
            TestRangeDynamic = new HashSet<TestRangeDynamic>();
            TestRunGroupOverrideTestStatus = new HashSet<TestRunGroup>();
            TestRunGroupTestStatus = new HashSet<TestRunGroup>();
            TestRunItemOverrideTestStatus = new HashSet<TestRunItem>();
            TestRunItemRange = new HashSet<TestRunItemRange>();
            TestRunItemTestStatus = new HashSet<TestRunItem>();
            TestRunOverrideTestStatus = new HashSet<TestRun>();
            TestRunTestStatus = new HashSet<TestRun>();
            TotalEquityWeightTestHistory = new HashSet<TotalEquityWeightTestHistory>();
        }

        public int TestStatusId { get; set; }
        public string TestStatusName { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<TestRange> TestRange { get; set; }
        public ICollection<TestRangeDynamic> TestRangeDynamic { get; set; }
        public ICollection<TestRunGroup> TestRunGroupOverrideTestStatus { get; set; }
        public ICollection<TestRunGroup> TestRunGroupTestStatus { get; set; }
        public ICollection<TestRunItem> TestRunItemOverrideTestStatus { get; set; }
        public ICollection<TestRunItemRange> TestRunItemRange { get; set; }
        public ICollection<TestRunItem> TestRunItemTestStatus { get; set; }
        public ICollection<TestRun> TestRunOverrideTestStatus { get; set; }
        public ICollection<TestRun> TestRunTestStatus { get; set; }
        public ICollection<TotalEquityWeightTestHistory> TotalEquityWeightTestHistory { get; set; }
    }
}
