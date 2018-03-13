using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class DateType
    {
        public DateType()
        {
            FinancialCalendar = new HashSet<FinancialCalendar>();
        }

        public int DateTypeId { get; set; }
        public string DateTypeCode { get; set; }
        public string DateTypeDescription { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<FinancialCalendar> FinancialCalendar { get; set; }
    }
}
