using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TotalEquityWeightTestHistory
    {
        public int TotalEquityWeightTestHistoryId { get; set; }
        public DateTime ValuationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int RunId { get; set; }
        public string TestName { get; set; }
        public int TestStatusId { get; set; }
        public int FundingAccountId { get; set; }
        public DateTime? Tdate { get; set; }
        public DateTime? T1date { get; set; }
        public DateTime? T2date { get; set; }

        public FundingAccounts FundingAccount { get; set; }
        public TestStatus TestStatus { get; set; }
    }
}
