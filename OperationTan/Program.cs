using System;

namespace Calculator.Operations
{
    public class OperationTan : Operation.Operation
    {
        public override string Operator { get; } = "tan";

        public OperationTan()
        {
            Operator = "tan";
        }

        public override double Execute(double a)
        {
            throw new System.NotImplementedException();
        }

        public override double Execute(double a, double b)
        {
            return Math.Tan(a);
        }
    }
}