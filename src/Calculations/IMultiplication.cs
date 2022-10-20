namespace Calculations;

public interface IMultiplication
{
    public double FirstNumber { get; }
    public double SecondNumber { get; }

    double Num1();
    double Num2();
    double Multiply(double num1, double num2);
    double DoMultiplication();
}
