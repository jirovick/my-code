using program;

namespace program
{
    public class PlusOperation : Operation
    {
        public override string Operator { get; } = "+";

        public PlusOperation()
        {
            Operator = "+";
        }

        public override double Execute(double a)
        {
            throw new System.NotImplementedException();
        }

        public override double Execute(double a, double b)
        {
            return a + b;
        }
    }
}