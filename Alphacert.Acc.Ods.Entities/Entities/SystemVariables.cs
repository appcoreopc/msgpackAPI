using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class SystemVariables
    {
        public string VariableName { get; set; }
        public string VariableValue { get; set; }
        public bool? IsLocked { get; set; }
        public string Description { get; set; }
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
