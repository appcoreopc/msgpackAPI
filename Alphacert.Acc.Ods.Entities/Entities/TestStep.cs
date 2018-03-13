using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class TestStep
    {
        public TestStep()
        {
            InverseOperandAtestStep = new HashSet<TestStep>();
            InverseOperandBtestStep = new HashSet<TestStep>();
            Test = new HashSet<Test>();
            TestRunItemStep = new HashSet<TestRunItemStep>();
        }

        public int TestStepId { get; set; }
        public string TestStepName { get; set; }
        public int TestStepTypeId { get; set; }
        public int? MeasurementId { get; set; }
        public string ExpressionName { get; set; }
        public int? OperandAtestStepId { get; set; }
        public int? OperandBtestStepId { get; set; }
        public string Operator { get; set; }
        public int Sequence { get; set; }
        public bool Inactive { get; set; }
        public DateTime DateCreated { get; set; }

        public Measurement Measurement { get; set; }
        public TestStep OperandAtestStep { get; set; }
        public TestStep OperandBtestStep { get; set; }
        public TestStepType TestStepType { get; set; }
        public ICollection<TestStep> InverseOperandAtestStep { get; set; }
        public ICollection<TestStep> InverseOperandBtestStep { get; set; }
        public ICollection<Test> Test { get; set; }
        public ICollection<TestRunItemStep> TestRunItemStep { get; set; }
    }
}
