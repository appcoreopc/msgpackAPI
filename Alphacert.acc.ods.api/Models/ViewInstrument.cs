using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alphacert.Acc.Ods.Api.Models
{
    public class ViewInstrument
    {
        public string InstrumentId { get; set; }
        public string InstrumentName { get; set; }
        public string ReportingCountryCode { get; set; }
        public string CurrencyCode { get; set; }
        public string ExposureCurrencyCode { get; set; }
        public DateTime ModifiedAt { get; set; }


    }
}
