namespace program
{
    public abstract class Operation
    {
        public abstract string Operator { get; }

        public abstract double Execute(double a);
        public abstract double Execute(double a, double b);
    }
}