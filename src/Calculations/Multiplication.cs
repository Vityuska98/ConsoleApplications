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

    public void Multiply()
    {
        Console.WriteLine($"{FirstNumber} multiplied by {SecondNumber} = " + (FirstNumber * SecondNumber));
    }

    public void MultiplyWorkFlow()
    {
        Console.WriteLine("Please enter the first number");
        FirstNumber = _validateInput.ValidateInput();
        Console.WriteLine("Please enter the second number");
        SecondNumber = _validateInput.ValidateInput();
        Multiply();
    }
}
