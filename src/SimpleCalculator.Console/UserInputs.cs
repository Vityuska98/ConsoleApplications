namespace SimpleCalculator;
using Calculations;

public class UserInputs:IUserInputs
{
    private double _firstNumber;
    public double FirstNumber
    {
        get { return _firstNumber; }
        set { _firstNumber = value; }
    }
    
    private double _secondNumber;
    public double SecondNumber
    {
        get { return _secondNumber; }
        set { _secondNumber = value; }
    }
    
}
