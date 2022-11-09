namespace Calculations;

public interface ISubtraction
{
    public double FirstNumber { get; }
    public double SecondNumber { get; }
    double Subtract(double num1, double num2);
}
