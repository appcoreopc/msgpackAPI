using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestRunType
    {
        public TestRunType()
        {
            TestRun = new HashSet<TestRun>();
        }

        public int TestRunTypeId { get; set; }
        public string TestRunTypeDescription { get; set; }
        public bool? Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<TestRun> TestRun { get; set; }
    }
}
