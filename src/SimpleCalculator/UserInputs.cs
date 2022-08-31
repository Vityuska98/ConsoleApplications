namespace SimpleCalculator;

public class UserInputs

{
    public static int GetUserInput(string message)
    {
        System.Console.WriteLine(message);
        string? input = Console.ReadLine();
        int inputNumber;
        while (!int.TryParse(input, out inputNumber))
        {
            System.Console.WriteLine("Unable to process...please enter a number");
            input = Console.ReadLine();
        }
        return inputNumber;
    }

}
