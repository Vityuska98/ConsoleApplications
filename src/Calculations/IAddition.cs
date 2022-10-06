namespace Calculations;

public interface IAddition
{
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }

    void AddWorkFlow();
    void Add();
}
