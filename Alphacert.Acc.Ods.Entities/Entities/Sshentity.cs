using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Sshentity
    {
        public Sshentity()
        {
            Sshevent = new HashSet<Sshevent>();
        }

        public int SshentityId { get; set; }
        public int ExchangeId { get; set; }
        public int? InstrumentId { get; set; }
        public int? IssuerId { get; set; }
        public int? SsheventTypeId { get; set; }
        public DateTime? DateNotified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? InActive { get; set; }
        public int? SshtestId { get; set; }
        public int? InstrumentSubTypeId { get; set; }

        public Exchange Exchange { get; set; }
        public Instrument Instrument { get; set; }
        public InstrumentSubType InstrumentSubType { get; set; }
        public Issuer Issuer { get; set; }
        public SsheventType SsheventType { get; set; }
        public Sshtest Sshtest { get; set; }
        public ICollection<Sshevent> Sshevent { get; set; }
    }
}
