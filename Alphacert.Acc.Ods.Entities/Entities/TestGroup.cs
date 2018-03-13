using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestGroup
    {
        public TestGroup()
        {
            InverseParentTestGroup = new HashSet<TestGroup>();
            TestDefinition = new HashSet<TestDefinition>();
            TestRunGroup = new HashSet<TestRunGroup>();
            TestRunItem = new HashSet<TestRunItem>();
        }

        public int TestGroupId { get; set; }
        public string TestGroupName { get; set; }
        public int? ParentTestGroupId { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? ExcludeFromAutoQueue { get; set; }

        public TestGroup ParentTestGroup { get; set; }
        public ICollection<TestGroup> InverseParentTestGroup { get; set; }
        public ICollection<TestDefinition> TestDefinition { get; set; }
        public ICollection<TestRunGroup> TestRunGroup { get; set; }
        public ICollection<TestRunItem> TestRunItem { get; set; }
    }
}
