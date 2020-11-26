namespace Calculator
{
    public interface IPresenter
    {
        string Person { get; set; }
        string GetAnswer(ICalculation calculation);
    }
}