using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class ReconciliationDefinitionRun
    {
        public int ReconciliationDefinitionRunId { get; set; }
        public int ReconciliationDefinitionId { get; set; }
        public int ReconciliationRunId { get; set; }
        public DateTime? ExecutionDateTime { get; set; }
        public int StatusId { get; set; }
        public string ResultXml { get; set; }

        public ReconciliationDefinition ReconciliationDefinition { get; set; }
        public ReconciliationRun ReconciliationRun { get; set; }
        public Status Status { get; set; }
    }
}
