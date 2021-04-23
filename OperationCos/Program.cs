using System;

namespace Calculator.Operations
{
    public class OperationCos: Operation.Operation
    {
        public override string Operator { get; } = "cos";

        public OperationCos()
        {
            Operator = "cos";
        }

        public override double Execute(double a)
        {
            throw new System.NotImplementedException();
        }

        public override double Execute(double a, double b)
        {
            return Math.Cos(a);
        }
    }
}