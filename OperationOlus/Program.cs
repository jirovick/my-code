namespace Calculator.Operations
{
    public class OperationPlus : Operation.Operation
    {
        public override string Operator { get; } = "+";

        public OperationPlus()
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