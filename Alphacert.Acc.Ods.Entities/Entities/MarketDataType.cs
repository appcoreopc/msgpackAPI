using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class MarketDataType
    {
        public MarketDataType()
        {
            InstrumentMarketData = new HashSet<InstrumentMarketData>();
        }

        public int MarketDataTypeId { get; set; }
        public string MarketDataTypeCode { get; set; }
        public string MarketDataTypeDesc { get; set; }
        public string MarketDataDatatype { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<InstrumentMarketData> InstrumentMarketData { get; set; }
    }
}
