using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class SwapHolidayList
    {
        public int SwapHolidayListId { get; set; }
        public string SwapHolidayListCode { get; set; }
        public string SwapHolidayListDesc { get; set; }
        public bool? Inactive { get; set; }
        public bool? FrequentlyUsed { get; set; }
    }
}
