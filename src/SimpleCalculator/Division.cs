namespace SimpleCalculator;

public class Division
{
    UserInputs inputs = new UserInputs();
    public decimal Divide()
    {
        decimal firstNumber = inputs.GetUserInput("Please enter the first number:");
        decimal secondNumber = inputs.GetUserInput("Please enter the second number:");
        decimal result = firstNumber / secondNumber;
        return result;
    }
}
