namespace SimpleCalculator;

public class Calculator
{
    public static void Main(string[] args)
    {
        try
        {
            do
            {
                int userOption;
                var display = new UserConsoleUI();
                display.WelcomeMessage();
                userOption = Convert.ToInt32(Console.ReadLine());

                switch (userOption)
                {

                    case 1:
                        Addition doAdd = new Addition();
                        doAdd.AdditionWorkFlow();
                        doAdd.Add();
                        break;

                    case 2:
                        var doSub = new Subtraction();
                        doSub.SubtractionWorkFlow();
                        doSub.Subtract();
                        break;

                    case 3:
                        var doMultiplication = new Multiplication();
                        doMultiplication.MultiplicationWorkflow();
                        doMultiplication.Multiply();
                        break;

                    case 4:
                        var doDivision = new Division();
                        doDivision.DivisionWorkFlow();
                        doDivision.Divide();
                        break;

                    default:
                        Console.WriteLine("Unable to process! Please enter the appropriate option");
                        break;
                }
                Console.WriteLine("Do you wish to try again? Please enter 1 to try again or Any key to Exit");
            } while (Console.ReadLine() == "1");
            Console.WriteLine("Good bye");
        }
        catch (Exception)
        {
            Console.WriteLine("Unable to Process! Try again with a number");
        }
    }
}
