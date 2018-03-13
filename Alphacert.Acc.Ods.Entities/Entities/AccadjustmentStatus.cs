using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AccadjustmentStatus
    {
        public AccadjustmentStatus()
        {
            AccadjustmentHistory = new HashSet<AccadjustmentHistory>();
            Holding = new HashSet<Holding>();
        }

        public int AdjustmentStatusId { get; set; }
        public string StatusCode { get; set; }
        public string Description { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<AccadjustmentHistory> AccadjustmentHistory { get; set; }
        public ICollection<Holding> Holding { get; set; }
    }
}
