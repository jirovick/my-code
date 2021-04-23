using program;

namespace program
{
    public class DivOperation : Operation
    {
        public override string Operator { get; } = "/";

        public DivOperation()
        {
            Operator = "/";
        }

        public override double Execute(double a)
        {
            throw new System.NotImplementedException();
        }

        public override double Execute(double a, double b)
        {
            return a / b;
        }
    }
}