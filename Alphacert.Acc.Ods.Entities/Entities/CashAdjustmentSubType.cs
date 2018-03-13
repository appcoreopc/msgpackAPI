using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class CashAdjustmentSubType
    {
        public CashAdjustmentSubType()
        {
            JpmcashAdjustment = new HashSet<JpmcashAdjustment>();
        }

        public int CashAdjustmentSubTypeId { get; set; }
        public string CashAdjustmentSubTypeCode { get; set; }
        public string CashAdjustmentSubTypeDesc { get; set; }
        public bool Inactive { get; set; }
        public int CashAdjustmentTypeId { get; set; }

        public CashAdjustmentType CashAdjustmentType { get; set; }
        public ICollection<JpmcashAdjustment> JpmcashAdjustment { get; set; }
    }
}
