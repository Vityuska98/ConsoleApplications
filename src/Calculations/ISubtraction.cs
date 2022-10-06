namespace Calculations;

public interface ISubtraction
{
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }
    void Subtract();
    void SubtractWorkFlow();
}
