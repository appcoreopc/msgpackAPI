using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AdditionalBenchmarkInstrument
    {
        public int AddBmInsId { get; set; }
        public int InstrumentId { get; set; }
        public int? PortfolioId { get; set; }

        public Instrument Instrument { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
