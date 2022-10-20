namespace Calculations;

public class Addition : IAddition
{
    private readonly IUserConsoleInputValidation _validateInput;
    public Addition(IUserConsoleInputValidation validateInput)
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
    public double DoAdd()
    {
        return Add(FirstNumber, SecondNumber);
    }
    public double Add(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber;
    }
}
