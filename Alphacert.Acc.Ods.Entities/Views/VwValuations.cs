﻿using System;

namespace Alphacert.Acc.Ods.Entities.Views
{
    
    public partial class VwValuations
    {
        public string Instrument_Name { get; set; }
              
        public int? InstrumentId { get; set; }
            
        public int? PortfolioId { get; set; }

        public decimal? Total_Market_Value_Base_Discount { get; set; }
        
        public DateTime? ValuationDate { get; set; }

    }
}
