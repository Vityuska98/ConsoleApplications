namespace SimpleCalculator;

public class Addition
{
    public double FirstNumber { get; private set; }
    public double SecondNumber { get; private set; }

    public void AdditionWorkFlow()
    {
        var display = new UserConsoleUI();
        display.RequestForUserInput("Please enter the first number");
        var validate = new UserConsoleInputValidation();
        FirstNumber = validate.ValidateInput();
        display.RequestForUserInput("Please enter the second number");
        SecondNumber = validate.ValidateInput();
    }

    public void Add()
    {
        Console.WriteLine($"{FirstNumber} + {SecondNumber} = " + (FirstNumber + SecondNumber));
    }

}
