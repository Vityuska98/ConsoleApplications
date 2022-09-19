namespace SimpleCalculator;

public class Subtraction
{
    private double _firstNumber;
    private double _secondNumber;

    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }

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
