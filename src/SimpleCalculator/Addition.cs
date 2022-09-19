namespace SimpleCalculator;

public class Addition
{
    private double _firstNumber;
    private double _secondNumber;
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }

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
