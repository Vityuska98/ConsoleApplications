namespace Calculations;
public interface IAddition
{
    public double FirstNumber { get; }
    public double SecondNumber { get; }

    double DoAdd();
    double Num1();
    double Num2();
    double Add(double num1, double num2);
}
