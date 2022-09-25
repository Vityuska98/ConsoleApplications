namespace SimpleCalculator;

public class Multiplication
{
    public double FirstNumber { get; private set; }
    public double SecondNumber { get; private set; }

    public void MultiplicationWorkflow()
    {
        var display = new UserConsoleUI();
        display.RequestForUserInput("Please enter the first number");
        var validate = new UserConsoleInputValidation();
        FirstNumber = validate.ValidateInput();
        display.RequestForUserInput("Please enter the second number");
        SecondNumber = validate.ValidateInput();
    }

    public void Multiply()
    {
        Console.WriteLine($"{FirstNumber} multiplied by {SecondNumber} = " + (FirstNumber * SecondNumber));
    }
}
