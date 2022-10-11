namespace SimpleCalculator;

public class UserConsoleUI
{
    public void WelcomeMessage()
    {
        Console.WriteLine("Welcome, User!");
        Console.WriteLine("Please enter a number that represents the following Math operators");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
    }

    public void RequestForUserInput(string message)
    {
        Console.WriteLine(message);
    }
}
