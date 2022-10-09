namespace Calculations;

public interface IMultiplication
{
    public double FirstNumber { get; }
    public double SecondNumber { get; }
    void Multiply();
    void MultiplyWorkFlow();
}
