using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Sshtest
    {
        public Sshtest()
        {
            Sshentity = new HashSet<Sshentity>();
            Sshevent = new HashSet<Sshevent>();
        }

        public int SshtestId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? InActive { get; set; }
        public int? NewEntityCount { get; set; }
        public int? EntryEventCount { get; set; }
        public int? MovementEventCount { get; set; }
        public int? CeaseEventCount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ValuationDate { get; set; }

        public ICollection<Sshentity> Sshentity { get; set; }
        public ICollection<Sshevent> Sshevent { get; set; }
    }
}
