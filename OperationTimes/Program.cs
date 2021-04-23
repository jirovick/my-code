namespace Calculator.Operations
{
    public class OperationPTimes : Operation.Operation
    {
        public override string Operator { get; } = "*";

        public OperationPTimes()
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