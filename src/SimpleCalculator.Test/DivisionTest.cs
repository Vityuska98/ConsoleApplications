using Calculations;
namespace SimpleCalculator.Test;

public class DivisionTest
{
    [Theory]
    [InlineData(3, 3, 1)]
    [InlineData(1.5, 0.5, 3)]
    public void Divide_TwoNumbersShouldDivide(double firstNumber, double secondNumber, double expected)
    {
        var divideTest = new Division();
        var actual = divideTest.Divide(firstNumber, secondNumber);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide_DivideByZero()
    {
        //At the moment, I can't figure out how to handle this.
    }
}
