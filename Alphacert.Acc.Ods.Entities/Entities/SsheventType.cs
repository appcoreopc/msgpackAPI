using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class SsheventType
    {
        public SsheventType()
        {
            Sshentity = new HashSet<Sshentity>();
            Sshevent = new HashSet<Sshevent>();
        }

        public int SsheventTypeId { get; set; }
        public string EventDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<Sshentity> Sshentity { get; set; }
        public ICollection<Sshevent> Sshevent { get; set; }
    }
}
