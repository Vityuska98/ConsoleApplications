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

    public void Subtract()
    {
        Console.WriteLine($"{FirstNumber} - {SecondNumber} = " + (FirstNumber - SecondNumber));
    }

    public void SubtractWorkFlow()
    {
        Console.WriteLine("Please enter the first number");
        FirstNumber = _validateInput.ValidateInput();
        Console.WriteLine("Please enter the second number");
        SecondNumber = _validateInput.ValidateInput();
        Subtract();
    }
}
