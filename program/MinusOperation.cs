namespace program
{
    public class MinusOperation : Operation
    {
        public override string Operator { get; } = "-";

        public MinusOperation()
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
}