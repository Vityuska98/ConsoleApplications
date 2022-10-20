namespace Calculations;

public class Subtraction : ISubtraction
{
    private readonly IUserConsoleInputValidation _validateInput;

    public Subtraction(IUserConsoleInputValidation validateInput)
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
    public double DoSubtraction()
    {
        return Subtract(FirstNumber, SecondNumber);
    }
    public double Subtract(double firstNumber, double secondNumber)
    {
        return firstNumber - secondNumber;
    }
}
