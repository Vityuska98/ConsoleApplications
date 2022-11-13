namespace Calculations;

public class Subtraction : ISubtraction
{
    public double FirstNumber { get; private set; }
    public double SecondNumber { get; private set; }

    public double Subtract(double firstNumber, double secondNumber)
    {
        return firstNumber - secondNumber;
    }
}
