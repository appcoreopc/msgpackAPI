using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ProviderRequestItem
    {
        public int ProviderRequestItemId { get; set; }
        public int ProviderRequestId { get; set; }
        public DateTime Created { get; set; }
        public int RequestTypeId { get; set; }
        public int RequestProviderId { get; set; }
        public int TableId { get; set; }
        public string SearchId { get; set; }
        public int InternalId { get; set; }
        public string UpdateDetails { get; set; }

        public ProviderRequest ProviderRequest { get; set; }
    }
}
