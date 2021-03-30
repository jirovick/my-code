using System;

namespace CalculatorApp.Operations
{
    public class OperarionMinus: Operation
    {
        public override string Operator { get; } = "+";

        public OperarionMinus()
        {
            Operator = "-";
        }

        public override double Execute(double a)
        {
            throw new System.NotImplementedException();
        }

        public override double Execute(double a, double b)
        {
            return a - b;
        }
    }

    public class CosinusOperation : Operation
    {
        public override string Operator { get; } = "cos";
        public override double Execute(double a)
        {
            return Math.Cos(a);
        }

        public override double Execute(double a, double b)
        {
            throw new System.NotImplementedException();
        }
    }
}