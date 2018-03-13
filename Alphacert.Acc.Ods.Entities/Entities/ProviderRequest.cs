using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ProviderRequest
    {
        public ProviderRequest()
        {
            ProviderRequestItem = new HashSet<ProviderRequestItem>();
        }

        public int ProviderRequestId { get; set; }
        public DateTime Created { get; set; }
        public int ProviderId { get; set; }
        public string ProviderRef { get; set; }
        public int InternalId { get; set; }
        public string RequestRawData { get; set; }
        public DateTime? RequestSent { get; set; }
        public string ResponseRawData { get; set; }
        public DateTime? ResponseReceived { get; set; }

        public Provider Provider { get; set; }
        public ICollection<ProviderRequestItem> ProviderRequestItem { get; set; }
    }
}
