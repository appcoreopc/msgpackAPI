using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentGroupType
    {
        public InstrumentGroupType()
        {
            InstrumentGroup = new HashSet<InstrumentGroup>();
        }

        public int InstrumentGroupTypeId { get; set; }
        public string InstrumentGroupCode { get; set; }
        public string InstrumentGroupDescription { get; set; }
        public bool? Inactive { get; set; }
        public DateTime? DateCreated { get; set; }

        public ICollection<InstrumentGroup> InstrumentGroup { get; set; }
    }
}
