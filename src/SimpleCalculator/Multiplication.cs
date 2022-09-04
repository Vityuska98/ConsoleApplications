namespace SimpleCalculator;

public class Multiplication
{
    UserInputs inputs = new UserInputs();
    public int Multiply()
    {
        int firstNumber = inputs.GetUserInput("Please enter the first number:");
        int secondNumber = inputs.GetUserInput("Please enter the second number:");

        int result = firstNumber * secondNumber;
        return result;
    }
}
