using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Test
    {
        public Test()
        {
            TestRange = new HashSet<TestRange>();
            TestRangeDynamic = new HashSet<TestRangeDynamic>();
            TestRunItem = new HashSet<TestRunItem>();
            TestRunItemStep = new HashSet<TestRunItemStep>();
        }

        public int TestId { get; set; }
        public DateTime DateCreated { get; set; }
        public int TestStepId { get; set; }
        public string Comment { get; set; }
        public int? StatusId { get; set; }
        public int? TestDefinitionId { get; set; }
        public int Version { get; set; }
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }

        public Status Status { get; set; }
        public TestDefinition TestDefinition { get; set; }
        public TestStep TestStep { get; set; }
        public ICollection<TestRange> TestRange { get; set; }
        public ICollection<TestRangeDynamic> TestRangeDynamic { get; set; }
        public ICollection<TestRunItem> TestRunItem { get; set; }
        public ICollection<TestRunItemStep> TestRunItemStep { get; set; }
    }
}
