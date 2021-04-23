using program;

namespace program
{
    public class TimesOperation : Operation
    {
        public override string Operator { get; } = "*";

        public TimesOperation()
        {
            Operator = "*";
        }

        public override double Execute(double a)
        {
            throw new System.NotImplementedException();
        }

        public override double Execute(double a, double b)
        {
            return a * b;
        }
    }
}