namespace SimpleCalculator;

public class Division
{
    public static decimal Divide()
    {
        decimal firstNumber = UserInputs.GetUserInput("Please enter the first number");
        decimal secondNumber = UserInputs.GetUserInput("Plwease enter the second number");
        decimal result = firstNumber / secondNumber;
        return result;
    }
}
