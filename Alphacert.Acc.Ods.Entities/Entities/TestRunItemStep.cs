using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestRunItemStep
    {
        public TestRunItemStep()
        {
            TestRunItemRange = new HashSet<TestRunItemRange>();
        }

        public int TestRunItemStepId { get; set; }
        public int TestRunItemId { get; set; }
        public int TestId { get; set; }
        public int TestStepId { get; set; }
        public string OutputXml { get; set; }
        public bool? Inactive { get; set; }
        public DateTime DateCreated { get; set; }
        public int? RunTimeMilliseconds { get; set; }

        public Test Test { get; set; }
        public TestRunItem TestRunItem { get; set; }
        public TestStep TestStep { get; set; }
        public ICollection<TestRunItemRange> TestRunItemRange { get; set; }
    }
}
