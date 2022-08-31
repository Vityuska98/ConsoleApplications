namespace SimpleCalculator;

public class Multiplication
{
    public static int Multiply()
    {
        int firstNumber = UserInputs.GetUserInput("Please enter the first number");
        int secondNumber = UserInputs.GetUserInput("Please enter the second number");

        int result = firstNumber * secondNumber;
        return result;
    }
}
