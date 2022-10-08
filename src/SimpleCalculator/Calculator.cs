using Microsoft.Extensions.DependencyInjection;
using Calculations;
namespace SimpleCalculator;

public class Calculator
{
    public static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddScoped<IAddition, Addition>()
            .AddScoped<IDivision, Division>()
            .AddScoped<IMultiplication, Multiplication>()
            .AddScoped<ISubtraction, Subtraction>()
            .AddScoped<IUserConsoleInputValidation, UserConsoleInputValidation>()
            .BuildServiceProvider();
        try
        {
            do
            {
                int userOption;
                Console.WriteLine("Welcome, User!");
                Console.WriteLine("Please enter a number that represents the following Math operators");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                userOption = Convert.ToInt32(Console.ReadLine());

                switch (userOption)
                {

                    case 1:
                        var addService = serviceProvider.GetService<IAddition>();
                        addService?.AddWorkFlow();
                        break;

                    case 2:
                        var subService = serviceProvider.GetService<ISubtraction>();
                        subService?.SubtractWorkFlow();
                        break;

                    case 3:
                        var multiplyService = serviceProvider.GetService<IMultiplication>();
                        multiplyService?.MultiplyWorkFlow();
                        break;

                    case 4:
                        var divideService = serviceProvider.GetService<IDivision>();
                        divideService?.DivideWorkFlow();
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
