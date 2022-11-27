using Calculations;
namespace SimpleCalculator.Test;

public class DivisionTest
{
    [Theory]
    [InlineData(3, 3, 1)]
    [InlineData(1.5, 0.5, 3)]
    [InlineData(-1, 0.5, -2)]
    public void Divide_TwoNumbersShouldDivide(double firstNumber, double secondNumber, double expected)
    {
        var inputs = new Division();
        var actual = inputs.Divide(firstNumber, secondNumber);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(12, 0, double.PositiveInfinity)]
    [InlineData(-10, 0, double.NegativeInfinity)]
    [InlineData(0, 0, double.NaN)]
    public void Divide_ShouldNotBeNumeric(double firstNumber, double secondNumber, double expected)
    {
        var inputs = new Division();
        var actual = inputs.Divide(firstNumber, secondNumber);
        Assert.Equal(expected, actual);
    }
}
