namespace Calculator
{
    public interface ICalculation
    {
        bool Verifiable { get; }
        double Evaluate();
        void GetA(double value);
        void GetB(double value);
    }
}