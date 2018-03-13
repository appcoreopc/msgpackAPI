using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestType
    {
        public TestType()
        {
            TestDefinition = new HashSet<TestDefinition>();
            TestRun = new HashSet<TestRun>();
        }

        public int TestTypeId { get; set; }
        public string TestTypeName { get; set; }
        public bool? Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<TestDefinition> TestDefinition { get; set; }
        public ICollection<TestRun> TestRun { get; set; }
    }
}
