using System;

namespace program
{
    public class TanOperation: Operation
    {
        public override string Operator { get; } = "tan";

        public TanOperation()
        {
            Operator = "tan";
        }

        public override double Execute(double a)
        {
            return Math.Tan(a);
        }

        public override double Execute(double a, double b)
        {
            throw new System.NotImplementedException();
        }
    }
}