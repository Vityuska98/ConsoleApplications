namespace Calculations;

public class Division : IDivision
{
    private readonly IUserConsoleInputValidation _validateInput;
    public Division(IUserConsoleInputValidation validateInput)
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
    public double DoDivision()
    {
        return Divide(FirstNumber, SecondNumber);
    }
    public double Divide(double firstNumber, double secondNumber)
    {
        return firstNumber / secondNumber;
    }
}
