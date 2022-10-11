namespace SimpleCalculator;

public class Division
{
    public double FirstNumber { get; private set; }
    public double SecondNumber { get; private set; }

    public void DivisionWorkFlow()
    {
        var display = new UserConsoleUI();
        display.RequestForUserInput("Please enter the first number");
        var validate = new UserConsoleInputValidation();
        FirstNumber = validate.ValidateInput();
        display.RequestForUserInput("Please enter the second number");
        SecondNumber = validate.ValidateDenominator();
    }

    public void Divide()
    {
        Console.WriteLine($"{FirstNumber} divided by {SecondNumber} = " + (FirstNumber / SecondNumber));
    }
}
