namespace Calculations;

public interface IMultiplication
{
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }
    void Multiply();
    void MultiplyWorkFlow();
}
