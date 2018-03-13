using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestStepType
    {
        public TestStepType()
        {
            TestStep = new HashSet<TestStep>();
        }

        public int TestStepTypeId { get; set; }
        public string TestStepTypeName { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<TestStep> TestStep { get; set; }
    }
}
