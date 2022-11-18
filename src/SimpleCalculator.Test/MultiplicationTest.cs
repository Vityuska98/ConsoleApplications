using Calculations;
namespace SimpleCalculator.Test;

public class MultiplicationTest
{
    [Theory]
    [InlineData(3, 3, 9)]
    [InlineData(3, 0, 0)]
    [InlineData(10, 9, 90)]
    public void Multiply_TwoNumbersShouldMultiply(double firstNumber, double secondNumber, double expected)
    {
        var multiplyTest = new Multiplication();
        var actual = multiplyTest.Multiply(firstNumber, secondNumber);
        Assert.Equal(expected, actual);
    }
}
