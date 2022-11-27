using Calculations;
namespace SimpleCalculator.Test;

public class MultiplicationTest
{
    [Theory]
    [InlineData(3, 3, 9)]
    [InlineData(3, 0, 0)]
    [InlineData(10, 9.2, 92)]
    [InlineData(-1.5, 0.5, -0.75)]
    public void Multiply_TwoNumbersShouldMultiply(double firstNumber, double secondNumber, double expected)
    {
        var inputs = new Multiplication();
        var actual = inputs.Multiply(firstNumber, secondNumber);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(double.MaxValue, 100, double.PositiveInfinity)]
    [InlineData(double.MaxValue, -100, double.NegativeInfinity)]
    public void Multiply_ShouldBeInfinity(double firstNumber, double secondNumber, double expected)
    {
        var inputs = new Multiplication();
        var actual = inputs.Multiply(firstNumber, secondNumber);
        Assert.Equal(expected, actual);
    }
}
