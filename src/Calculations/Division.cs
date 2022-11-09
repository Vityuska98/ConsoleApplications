namespace Calculations;

public class Division : IDivision
{
    public double FirstNumber { get; private set; }
    public double SecondNumber { get; private set; }

    public double Divide(double firstNumber, double secondNumber)
    {
        return firstNumber / secondNumber;
    }
}
