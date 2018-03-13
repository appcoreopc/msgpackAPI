using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestRange
    {
        public TestRange()
        {
            TestRunItemRange = new HashSet<TestRunItemRange>();
        }

        public int TestRangeId { get; set; }
        public string TestRangeName { get; set; }
        public int TestId { get; set; }
        public decimal? LowerLimit { get; set; }
        public decimal? UpperLimit { get; set; }
        public int TestStatusId { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }
        public string RangeType { get; set; }

        public Test Test { get; set; }
        public TestStatus TestStatus { get; set; }
        public ICollection<TestRunItemRange> TestRunItemRange { get; set; }
    }
}
