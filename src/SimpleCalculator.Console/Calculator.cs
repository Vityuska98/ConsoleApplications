using Microsoft.Extensions.DependencyInjection;
using Calculations;
namespace SimpleCalculator;

public class Calculator
{
    public static void Main(string[] args)
    {
        var serviceProvider = Startup.Configure();
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
                IUserInputValidation input = serviceProvider.GetService<IUserInputValidation>();
                double num1;
                double num2;
                switch (userOption)
                {
                    case 1:
                        var addService = serviceProvider.GetService<IAddition>();
                        Console.WriteLine("Please enter the first number");
                        num1 = input.ValidateInput();
                        Console.WriteLine("Please enter the second number");
                        num2 = input.ValidateInput();
                        Console.WriteLine(addService?.Add(num1, num2));
                        break;

                    case 2:
                        var subService = serviceProvider.GetService<ISubtraction>();
                        Console.WriteLine("Please enter the first number");
                        num1 = input.ValidateInput();
                        Console.WriteLine("Please enter the second number");
                        num2 = input.ValidateInput();
                        Console.WriteLine(subService?.Subtract(num1, num2));
                        break;

                    case 3:
                        var multiplyService = serviceProvider.GetService<IMultiplication>();
                        Console.WriteLine("Please enter the first number");
                        num1 = input.ValidateInput();
                        Console.WriteLine("Please enter the second number");
                        num2 = input.ValidateInput();
                        Console.WriteLine(multiplyService?.Multiply(num1, num2));
                        break;

                    case 4:
                        var divideService = serviceProvider.GetService<IDivision>();
                        Console.WriteLine("Please enter the first number");
                        var numerator = input.ValidateInput();
                        Console.WriteLine("Please enter the second number");
                        var denominator = input.ValidateDenominator();
                        Console.WriteLine(divideService?.Divide(numerator, denominator));
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
