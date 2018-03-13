using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestDefinition
    {
        public TestDefinition()
        {
            Test = new HashSet<Test>();
        }

        public int TestDefinitionId { get; set; }
        public int TestGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TestTypeId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public bool? BlockInterim { get; set; }
        public bool? Ignore { get; set; }
        public bool? Inactive { get; set; }

        public TestGroup TestGroup { get; set; }
        public TestType TestType { get; set; }
        public ICollection<Test> Test { get; set; }
    }
}
