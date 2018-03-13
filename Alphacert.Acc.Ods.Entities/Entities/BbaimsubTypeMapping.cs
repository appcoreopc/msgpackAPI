using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class BbaimsubTypeMapping
    {
        public long BbaimsubTypeMappingId { get; set; }
        public string MarketSector2 { get; set; }
        public string BbSubflag { get; set; }
        public string SecurityTyp2 { get; set; }
        public string Description { get; set; }
        public int? InstrumentTypeId { get; set; }
        public int? InstrumentSubTypeId { get; set; }

        public InstrumentSubType InstrumentSubType { get; set; }
        public InstrumentType InstrumentType { get; set; }
    }
}
