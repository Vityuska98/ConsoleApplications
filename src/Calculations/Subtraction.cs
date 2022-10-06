namespace Calculations;

public class Subtraction : ISubtraction
{
    private readonly IUserConsoleInputValidation _validateInput;

    public Subtraction(IUserConsoleInputValidation validateInput)
    {
        _validateInput = validateInput;
    }
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }

    public void Subtract()
    {
        Console.WriteLine(FirstNumber - SecondNumber);
    }

    public void SubtractWorkFlow()
    {
        Console.WriteLine("Please enter the first number");
        FirstNumber = _validateInput.ValidateInput();
        Console.WriteLine("Please enter the second number");
        SecondNumber = _validateInput.ValidateInput();
    }
}
