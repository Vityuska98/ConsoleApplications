using Microsoft.Extensions.DependencyInjection;
using Calculations;
namespace SimpleCalculator;

public class Calculator
{
    public static void Main(string[] args)
    {
        var number = new UserInputs();
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
                
                Console.WriteLine("Please enter the first number");
                number.SecondNumber = input.ValidateInput();
                Console.WriteLine("Please enter the second number");
                number.SecondNumber = input.ValidateInput();
                switch (userOption)
                {
                    case 1:
                        var addService = serviceProvider.GetService<IAddition>();
                        Console.WriteLine(addService?.Add(number.FirstNumber, number.SecondNumber));
                        break;

                    case 2:
                        var subService = serviceProvider.GetService<ISubtraction>();
                        Console.WriteLine(subService?.Subtract(number.FirstNumber, number.SecondNumber));
                        break;

                    case 3:
                        var multiplyService = serviceProvider.GetService<IMultiplication>();
                        Console.WriteLine(multiplyService?.Multiply(number.FirstNumber, number.SecondNumber));
                        break;

                    case 4:
                        var divideService = serviceProvider.GetService<IDivision>();
                        number.SecondNumber = input.ValidateDenominator();
                        Console.WriteLine(divideService?.Divide(number.FirstNumber, number.SecondNumber));
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
