using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        DivideNumbers(input1, input2);
    }

    static void DivideNumbers(string num1, string num2)
    {
        try
        {
            // Convert the string inputs to integers
            int number1 = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);

            // Perform the division
            int result = number1 / number2;

            Console.WriteLine($"Result: {number1} / {number2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: One or both inputs are not valid integers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number entered is too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}

