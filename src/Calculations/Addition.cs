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

    public void AddWorkFlow()
    {
        Console.WriteLine("Please enter the firstNumber");
        FirstNumber = _validateInput.ValidateInput();
        Console.WriteLine("Please enter the second number");
        SecondNumber = _validateInput.ValidateInput();
        Add();
    }
    public void Add()
    {
        Console.WriteLine($"{FirstNumber} + {SecondNumber} = " + (FirstNumber + SecondNumber));
    }
}
