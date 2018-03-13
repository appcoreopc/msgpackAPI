using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ProviderDataSource
    {
        public ProviderDataSource()
        {
            Instrument = new HashSet<Instrument>();
        }

        public int ProviderDataSourceId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? ProviderId { get; set; }
        public bool? Inactive { get; set; }

        public Provider Provider { get; set; }
        public ICollection<Instrument> Instrument { get; set; }
    }
}
