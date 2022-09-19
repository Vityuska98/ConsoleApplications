namespace SimpleCalculator;

public class UserConsoleInputValidation
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
}
