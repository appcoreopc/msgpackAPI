using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class FutureInstrument
    {
        public int FutureInstrumentId { get; set; }
        public string ContractCode { get; set; }
        public string IdstickerPrefix { get; set; }
        public bool? Inactive { get; set; }
    }
}
