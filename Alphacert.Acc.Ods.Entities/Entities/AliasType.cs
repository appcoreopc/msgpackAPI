using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AliasType
    {
        public AliasType()
        {
            CounterPartyAlias = new HashSet<CounterPartyAlias>();
        }

        public int AliasTypeId { get; set; }
        public string AliasTypeCode { get; set; }
        public string AliasTypeDesc { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<CounterPartyAlias> CounterPartyAlias { get; set; }
    }
}
