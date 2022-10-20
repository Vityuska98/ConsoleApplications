namespace Calculations;

public class Multiplication : IMultiplication
{
    private readonly IUserConsoleInputValidation _validateInput;

    public Multiplication(IUserConsoleInputValidation validateInput)
    {
        _validateInput = validateInput;
    }

    public double FirstNumber { get; private set; }
    public double SecondNumber { get; private set; }

    public double Num1()
    {
        return FirstNumber = _validateInput.ValidateInput();
    }

    public double Num2()
    {
        return SecondNumber = _validateInput.ValidateInput();
    }
    public double DoMultiplication()
    {
        return Multiply(FirstNumber, SecondNumber);
    }
    public double Multiply(double firstNumber, double secondNumber)
    {
        return firstNumber * secondNumber;
    }
}

