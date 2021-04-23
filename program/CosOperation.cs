using System;

namespace program
{
    public class CosOperation: Operation
    {
        public override string Operator { get; } = "cos";

        public CosOperation()
        {
            Operator = "cos";
        }

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