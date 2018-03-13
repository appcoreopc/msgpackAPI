using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class CashAdjustmentType
    {
        public CashAdjustmentType()
        {
            CashAdjustmentSubType = new HashSet<CashAdjustmentSubType>();
        }

        public int CashAdjustmentTypeId { get; set; }
        public string CashAdjustmentTypeCode { get; set; }
        public string CashAdjustmentTypeDesc { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<CashAdjustmentSubType> CashAdjustmentSubType { get; set; }
    }
}
