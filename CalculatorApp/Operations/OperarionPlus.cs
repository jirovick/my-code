namespace CalculatorApp.Operations
{
    public class OperarionPlus : Operation
    {
        public OperarionPlus()
        {
            Operator = "+";
        }

        public override string Operator { get; }
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