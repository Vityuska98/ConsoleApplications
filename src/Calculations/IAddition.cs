namespace Calculations;
public interface IAddition
{
    public double FirstNumber { get; }
    public double SecondNumber { get; }
    double Add(double num1, double num2);
}
