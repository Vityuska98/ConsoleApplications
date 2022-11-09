using Calculations;
namespace SimpleCalculator;

public class UserConsoleInputValidation : IUserInputValidation
{
    public double ValidateInput()
    {
        double userInput = 0;
        while (!double.TryParse(Console.ReadLine(), out userInput))
        {
            Console.WriteLine("Please enter a valid number");
        }
        return userInput;
    }

    public double ValidateDenominator()
    {
        double denominator = 0;
        while (!double.TryParse(Console.ReadLine(), out denominator) || denominator == 0)
        {
            Console.WriteLine("Oops you have either typed zero or a letter. Please enter a non-zero number");
        }
        return denominator;
    }
}
