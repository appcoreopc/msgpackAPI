using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentGroupProperty
    {
        public int InstrumentGroupPropertyId { get; set; }
        public int InstrumentGroupId { get; set; }
        public string InstrumentGroupPropertyDescription { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public bool? Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public InstrumentGroup InstrumentGroup { get; set; }
    }
}
