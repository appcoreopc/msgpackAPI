using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class BbaimswapMapping
    {
        public long BbaimswapMappingId { get; set; }
        public string SwapFrequency { get; set; }
        public string SwapConvention { get; set; }
        public string SwapDayCount { get; set; }
        public string SwapFixingName { get; set; }
        public string SwapHolidayList { get; set; }
        public string Description { get; set; }
        public string Idscode { get; set; }
    }
}
