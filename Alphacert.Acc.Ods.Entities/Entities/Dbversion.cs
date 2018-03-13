using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Dbversion
    {
        public int Id { get; set; }
        public string VersionName { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public int BuildVersion { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
