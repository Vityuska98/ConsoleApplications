namespace Calculations;

public interface IMultiplication
{
    public double FirstNumber { get; }
    public double SecondNumber { get; }
    double Multiply(double num1, double num2);
}
