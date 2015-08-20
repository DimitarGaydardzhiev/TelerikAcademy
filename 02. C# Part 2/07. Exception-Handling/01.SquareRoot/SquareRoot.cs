/*
Problem 1. Square root
Write a program that reads an integer number and calculates and prints its square root. 
◦ If the number is invalid or negative, print  Invalid number .
◦ In all cases finally print  Good bye .
• Use  try-catch-finally  block.
*/
using System;
class SquareRoot
{
    static void Main()
    {
        Console.Write("Enter number = ");
        
        try
        {
            double number = double.Parse(Console.ReadLine());
            double result = Math.Sqrt(number);
            if (number < 0)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine("The square root of {0} is: {1:F2}", number, result);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

