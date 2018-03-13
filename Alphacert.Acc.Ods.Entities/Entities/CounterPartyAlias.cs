using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class CounterPartyAlias
    {
        public int CounterPartyAliasId { get; set; }
        public string Alias { get; set; }
        public int? AliasTypeId { get; set; }
        public int CounterPartyId { get; set; }
        public int? BatchId { get; set; }
        public int? LoadId { get; set; }
        public DateTime? Created { get; set; }
        public bool? Inactive { get; set; }

        public AliasType AliasType { get; set; }
        public CounterParty CounterParty { get; set; }
    }
}
