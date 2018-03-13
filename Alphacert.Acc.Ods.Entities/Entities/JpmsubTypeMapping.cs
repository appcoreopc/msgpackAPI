using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class JpmsubTypeMapping
    {
        public long JpmsubTypeMappingId { get; set; }
        public string JpmsecurityCategoryCode { get; set; }
        public string JpmsecurityCategoryTypeCode { get; set; }
        public string Gldescription { get; set; }
        public string JpmsectorLevel1 { get; set; }
        public string JpmsectorLevel4 { get; set; }
        public string SecurityType { get; set; }
        public int? InstrumentTypeId { get; set; }
        public int? InstrumentSubTypeId { get; set; }
        public DateTime DateCreated { get; set; }

        public InstrumentSubType InstrumentSubType { get; set; }
        public InstrumentType InstrumentType { get; set; }
    }
}
