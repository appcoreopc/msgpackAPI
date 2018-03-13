using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class AdminChangeLog
    {
        public int AdminChangeLogId { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string Table { get; set; }
        public string TableKey { get; set; }
        public string Column { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
