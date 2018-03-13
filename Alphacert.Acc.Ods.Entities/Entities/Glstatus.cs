using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Glstatus
    {
        public Glstatus()
        {
            GlstatusHistory = new HashSet<GlstatusHistory>();
        }

        public int GlstatusId { get; set; }
        public string StatusCode { get; set; }
        public string Description { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<GlstatusHistory> GlstatusHistory { get; set; }
    }
}
