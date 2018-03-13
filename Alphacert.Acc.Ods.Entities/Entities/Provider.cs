using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Provider
    {
        public Provider()
        {
            ProviderDataSource = new HashSet<ProviderDataSource>();
            ProviderRequest = new HashSet<ProviderRequest>();
        }

        public int ProviderId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<ProviderDataSource> ProviderDataSource { get; set; }
        public ICollection<ProviderRequest> ProviderRequest { get; set; }
    }
}
