namespace SimpleCalculator;

public class Division
{
    private double _firstNumber;
    private double _secondNumber;
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }

    public void DivisionWorkFlow()
    {
        var display = new UserConsoleUI();
        display.RequestForUserInput("Please enter the first number");
        var validate = new UserConsoleInputValidation();
        FirstNumber = validate.ValidateInput();
        display.RequestForUserInput("Please enter the second number");
        SecondNumber = validate.ValidateInput();
    }

    public void Divide()
    {

        if (SecondNumber == 0)
        {
            Console.WriteLine("Not divisible by zero 0. Enter a non-zero number next time");
        }
        else
        {
            Console.WriteLine($"{FirstNumber} divided by {SecondNumber} = " + (FirstNumber / SecondNumber));
        }
    }
}
