namespace Calculations;

public interface ISubtraction
{
    public double FirstNumber { get; }
    public double SecondNumber { get; }

    double Num1();
    double Num2();
    double Subtract(double num1, double num2);
    double DoSubtraction();
}
