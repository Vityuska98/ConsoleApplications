namespace SimpleCalculator;

public class Calculator
{
    public static void Main(string[]args)
    {
        Addition add = new Addition();
        Subtraction subtract = new Subtraction();
        Division divide = new Division();
        Multiplication multiply = new Multiplication();
        try
        {
            do
            {
                int userOption;
                System.Console.WriteLine("Welcome, dear!");
                System.Console.WriteLine("Please enter a number that represents the following Math operators");
                System.Console.WriteLine("1. Addition");
                System.Console.WriteLine("2. Subtraction");
                System.Console.WriteLine("3. Multiplication");
                System.Console.WriteLine("4. Division");
                userOption = Convert.ToInt32(Console.ReadLine());

                switch (userOption)
                {

                    case 1:
                        System.Console.WriteLine("The result of the addition is " +  add.Add());
                        break;
                    case 2:
                        System.Console.WriteLine("The result of the subtraction is " + subtract.Subtract());
                        break;
                    case 3:
                        System.Console.WriteLine("The result of the multiplication is " + multiply.Multiply());
                        break;
                    case 4:
                        System.Console.WriteLine("The result of the division is " + divide.Divide());
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
