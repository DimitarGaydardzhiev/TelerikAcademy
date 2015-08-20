
//Problem 8. Numbers from 1 to n
//Write a program that reads an integer number  n  from the console and prints all the numbers in the interval  [1..n] , each on a single line.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.Write("Please enter positive number: ");
            int newNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= newNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
