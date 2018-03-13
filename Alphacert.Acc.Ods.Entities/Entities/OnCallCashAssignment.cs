using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class OnCallCashAssignment
    {
        public int OnCallCashAssignmentId { get; set; }
        public int InstrumentId { get; set; }
        public int? PortfolioId { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime StatementDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int PeriodOfInterest { get; set; }
        public decimal Amount { get; set; }
        public bool? Inactive { get; set; }

        public Instrument Instrument { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
