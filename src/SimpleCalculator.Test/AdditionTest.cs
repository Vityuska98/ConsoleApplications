using Calculations;
namespace SimpleCalculator.Test;

public class AdditionTest
{
    [Theory]
    [InlineData(4, 3, 7)]
    [InlineData(5.5, 3, 8.5)]
    [InlineData(19.0, 0, 19)]
    [InlineData(-23, -1.3, -24.3)]
    [InlineData(double.MaxValue, 3, double.MaxValue)]
    public void Add_TwoNumbersShouldAdd(double firstNumber, double secondNumber, double expected)
    {
        var addTest = new Addition();
        double actual = addTest.Add(firstNumber, secondNumber);
        Assert.Equal(expected, actual);
    }
}
