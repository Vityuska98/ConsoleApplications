using Calculations;
namespace SimpleCalculator;

public class RunApplication
{
    private readonly IAddition _addition;
    private readonly IDivision _division;
    private readonly IMultiplication _multiplication;
    private readonly ISubtraction _subtraction;

    public RunApplication(IAddition addition, IDivision division, IMultiplication multiplication, ISubtraction subtraction)
    {
        _addition = addition;
        _division = division;
        _multiplication = multiplication;
        _subtraction = subtraction;
    }

    public void RunAddition()
    {
        _addition.AddWorkFlow();
        _addition.Add();
    }

    public void RunMultiplication()
    {
        _multiplication.MultiplyWorkFlow();
        _multiplication.Multiply();
    }

    public void RunDivision()
    {
        _division.DivideWorkFlow();
        _division.Divide();
    }

    public void RunSubtraction()
    {
        _subtraction.SubtractWorkFlow();
        _subtraction.Subtract();
    }
}
