namespace Calculations;

public class Division : IDivision
{
    private readonly IUserConsoleInputValidation _validateInput;

    public Division(IUserConsoleInputValidation validateInput)
    {
        _validateInput = validateInput;
    }

    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }

    public void Divide()
    {
        Console.WriteLine($"{FirstNumber} divided by {SecondNumber} = " + (FirstNumber / SecondNumber));
    }

    public void DivideWorkFlow()
    {
        Console.WriteLine("Please enter the first number");
        FirstNumber = _validateInput.ValidateInput();
        Console.WriteLine("Please enter the second number");
        SecondNumber = _validateInput.ValidateDenominator();
        Divide();
    }
}
