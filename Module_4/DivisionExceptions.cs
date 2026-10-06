using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string number1 = Console.ReadLine();

        Console.Write("Enter another number: ");
        string number2 = Console.ReadLine();

        Divide(number1, number2);
    }

    static void Divide(string number1, string number2)
    {
        try
        {
            int num1 = Convert.ToInt32(number1);
            int num2 = Convert.ToInt32(number2);

            int answer = num1 / num2;

            Console.WriteLine("The answer is: " + answer);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter numbers only.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: A number cannot be divided by zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number entered is too large.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Something went wrong.");
        }
    }
}