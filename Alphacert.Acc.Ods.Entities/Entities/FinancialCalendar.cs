using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class FinancialCalendar
    {
        public int CalendarId { get; set; }
        public DateTime CalendarDate { get; set; }
        public string DateDescription { get; set; }
        public int DateTypeId { get; set; }
        public int? InstrumentTypeId { get; set; }
        public string CountryCode { get; set; }
        public string ExchangeCode { get; set; }
        public string Notes { get; set; }

        public DateType DateType { get; set; }
        public InstrumentType InstrumentType { get; set; }
    }
}
