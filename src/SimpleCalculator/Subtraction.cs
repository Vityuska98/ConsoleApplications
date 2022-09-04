namespace SimpleCalculator;

public class Subtraction
{
    UserInputs inputs = new UserInputs();
    public int Subtract()
    {
        int firstNumber = inputs.GetUserInput("Please enter the first number:");
        int secondNumber = inputs.GetUserInput("Please enter the second number:");

        int result = firstNumber - secondNumber;
        return result;
    }
}
