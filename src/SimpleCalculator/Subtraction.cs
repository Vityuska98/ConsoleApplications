namespace SimpleCalculator;

public class Subtraction
{
    public double FirstNumber { get; private set; }
    public double SecondNumber { get; private set; }

    public void SubtractionWorkFlow()
    {
        var display = new UserConsoleUI();
        display.RequestForUserInput("Please enter the first number");
        var validate = new UserConsoleInputValidation();
        FirstNumber = validate.ValidateInput();
        display.RequestForUserInput("Please enter the second number");
        SecondNumber = validate.ValidateInput();
    }

    public void Subtract()
    {
        Console.WriteLine($"{FirstNumber} - {SecondNumber} = " + (FirstNumber - SecondNumber));
    }

}
