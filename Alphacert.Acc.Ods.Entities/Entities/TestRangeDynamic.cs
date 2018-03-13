using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestRangeDynamic
    {
        public TestRangeDynamic()
        {
            TestRunItemRange = new HashSet<TestRunItemRange>();
        }

        public int TestRangeDynamicId { get; set; }
        public string TestRangeDynamicName { get; set; }
        public int TestId { get; set; }
        public int MeasurementId { get; set; }
        public string LowerLimitPropertyName { get; set; }
        public string UpperLimitPropertyName { get; set; }
        public int TestStatusId { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }
        public string RangeType { get; set; }

        public Measurement Measurement { get; set; }
        public Test Test { get; set; }
        public TestStatus TestStatus { get; set; }
        public ICollection<TestRunItemRange> TestRunItemRange { get; set; }
    }
}
