namespace SimpleCalculator;

public class Subtraction
{
    public static int Subtract()
    {
        int firstNumber = UserInputs.GetUserInput("Please enter the first number");
        int secondNumber = UserInputs.GetUserInput("Please enter the second number");

        int result = firstNumber - secondNumber;
        return result;
    }
}
