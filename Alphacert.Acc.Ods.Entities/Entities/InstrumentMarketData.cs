using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentMarketData
    {
        public int InstrumentMarketDataId { get; set; }
        public int InstrumentId { get; set; }
        public int MarketDataTypeId { get; set; }
        public string MarketDataSource { get; set; }
        public string MarketDataValue { get; set; }
        public DateTime? MarketDataDate { get; set; }
        public int? BatchId { get; set; }
        public bool? InActive { get; set; }
        public int? BenchmarkInstrumentId { get; set; }
        public bool? Iiflag { get; set; }
        public bool? Pending { get; set; }

        public Instrument BenchmarkInstrument { get; set; }
        public Instrument Instrument { get; set; }
        public MarketDataType MarketDataType { get; set; }
    }
}
