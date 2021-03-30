namespace CalculatorApp.Operations
{
    public class OperarionDiv: Operation
    {
        public override string Operator { get; } = "/";

        public OperarionDiv()
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