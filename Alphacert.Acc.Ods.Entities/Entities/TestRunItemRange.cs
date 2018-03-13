using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestRunItemRange
    {
        public int TestRunItemRangeId { get; set; }
        public int TestRunItemStepId { get; set; }
        public string RangeXml { get; set; }
        public int? TestRangeId { get; set; }
        public int TestStatusId { get; set; }
        public bool? Inactive { get; set; }
        public DateTime DateCreated { get; set; }
        public int? TestRangeDynamicId { get; set; }
        public decimal? LowerLimit { get; set; }
        public decimal? UpperLimit { get; set; }
        public string RangeType { get; set; }

        public TestRange TestRange { get; set; }
        public TestRangeDynamic TestRangeDynamic { get; set; }
        public TestRunItemStep TestRunItemStep { get; set; }
        public TestStatus TestStatus { get; set; }
    }
}
