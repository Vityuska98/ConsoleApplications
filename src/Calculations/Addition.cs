namespace Calculations;

public class Addition : IAddition
{
    public double FirstNumber { get; private set; }
    public double SecondNumber { get; private set; }
    
    public double Add(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber;
    }
}
