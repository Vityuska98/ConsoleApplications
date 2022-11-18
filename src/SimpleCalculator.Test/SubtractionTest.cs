using Calculations;
namespace SimpleCalculator.Test;

public class SubtractionTest
{
    [Theory]
    [InlineData(3, 3, 0)]
    [InlineData(-1.5, 3, -4.5)]
    [InlineData(10, 9, 1)]
    public void Subtract_TwoNumbersShouldSubtract(double firstNumber, double secondNumber, double expected)
    {
        var subtractTest = new Subtraction();
        var actual = subtractTest.Subtract(firstNumber, secondNumber);
        Assert.Equal(expected, actual);
    }
}
