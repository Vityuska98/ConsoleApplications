namespace Calculations;

public interface IDivision
{
    public double FirstNumber { get; }
    public double SecondNumber { get; }

    double Num1();
    double Num2();
    double DoDivision();
    double Divide(double num1, double num2);
}
