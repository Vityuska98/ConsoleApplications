namespace Calculations;

public class Multiplication : IMultiplication
{
    public double FirstNumber { get; private set; }
    public double SecondNumber { get; private set; }

    public double Multiply(double firstNumber, double secondNumber)
    {
        return firstNumber * secondNumber;
    }
}

