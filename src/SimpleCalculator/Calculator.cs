namespace SimpleCalculator;

public class Calculator
{
    public static void Main()
    {
        try
        {
            do
            {
                int userOption;
                System.Console.WriteLine("Welcome, dear!");
                System.Console.WriteLine("Please enter a number that corresponds to one of the following Math operators");
                System.Console.WriteLine("1. Addition");
                System.Console.WriteLine("2. Subtraction");
                System.Console.WriteLine("3. Multiplication");
                System.Console.WriteLine("4. Division");
                userOption = Convert.ToInt32(Console.ReadLine());

                switch (userOption)
                {

                    case 1:
                        System.Console.WriteLine(Addition.Add());
                        break;
                    case 2:
                        System.Console.WriteLine(Subtraction.Subtract());
                        break;
                    case 3:
                        System.Console.WriteLine(Multiplication.Multiply());
                        break;
                    case 4:
                        System.Console.WriteLine(Division.Divide());
                        break;
                    default:
                        System.Console.WriteLine("Unable to process...Please enter the appropriate option");
                        break;
                }
                System.Console.WriteLine("Do you wish to Continue? Please enter 1 to Continue or Any key to Exit");
            } while (Console.ReadLine() == "1");
            System.Console.WriteLine("Good bye");
        }
        catch (System.Exception)
        {

            System.Console.WriteLine("Unable to Process...Try again with a number");
        }

    }
}
