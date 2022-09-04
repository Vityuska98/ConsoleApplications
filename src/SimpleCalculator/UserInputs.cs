namespace SimpleCalculator;

public class UserInputs
{
    private string userInput;
    public string UserInput
    {
        get { return userInput; }
        set { userInput = value; }
    }
    
    public int GetUserInput(string userInstruction)
    {
        System.Console.WriteLine(userInstruction);
        UserInput = Console.ReadLine();
        int inputNumber;
        while (!int.TryParse(UserInput, out inputNumber))
        {
            System.Console.WriteLine("Unable to process...please enter a number");
            UserInput = Console.ReadLine();
        }
        return inputNumber;
    }

}
