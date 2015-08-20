/*
Problem 13. Solve tasks
Write a program that can solve these tasks:
◦ Reverses the digits of a number
◦ Calculates the average of a sequence of integers
◦ Solves a linear equation  a * x + b = 0  

• Create appropriate methods.
• Provide a simple text-based menu for the user to choose which task to solve.
• Validate the input data:
◦ The decimal number should be non-negative
◦ The sequence should not be empty
◦  a  should not be equal to  0  
*/
using System;
using System.Collections.Generic;
class SolveTasks
{
    static List<char> Reverse(decimal number)
    {
        string str = Convert.ToString(number);
        List<char> digitList = new List<char>();

        foreach (var symbol in str)
        {
            digitList.Add(symbol);
        }

        digitList.Reverse();
        return digitList;
    }
    static decimal Average (decimal[] numbers)
    {
        decimal sum = 0;
        decimal result = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

           result = sum / numbers.Length;
        
        return result;
    }
    static decimal SolvesEquation (decimal a, decimal b)
    {
        decimal result = -b / a;
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Please select a task to solve, from the list below:\n");
        Console.WriteLine("1. Reverses the digits of a number");
        Console.WriteLine("2. Calculates the average of a sequence of integers");
        Console.WriteLine("3. RSolves a linear equation  a * x + b = 0");
        int numberOfTask = int.Parse(Console.ReadLine());

        if (numberOfTask == 1)
        {
            Console.Write("Enter a decimal number to reverse: ");
            decimal number = decimal.Parse(Console.ReadLine());

            if (number >= 0)
            {
                List<char> result = Reverse(number);

                for (int i = 0; i < result.Count; i++)
                {
                    Console.Write("The reversed number is: {0}", result[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Not a valid number, please enter a positive number!");
            }
        }
        else if (numberOfTask == 2)
        {
            Console.WriteLine("Enter a sequence to calculate (separate the values by \",\"): ");

            string line = Console.ReadLine();
            string[] arrStr = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            decimal[] arr = new decimal[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
            {
                arr[i] = decimal.Parse(arrStr[i]);
            }

            if (arr.Length > 0)
            {
                decimal result = Average(arr);
                Console.WriteLine("The average value of the sequence is: {0:F2}", result);
            }
            else
            {
                Console.WriteLine("The sequence is empty!");
            }
        }
        else if (numberOfTask == 3)
        {
            Console.Write("Please enter a = ");
            decimal a = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter b = ");
            decimal b = decimal.Parse(Console.ReadLine());

            if (a != 0)
            {
                decimal result = SolvesEquation(a, b);
                Console.WriteLine("For the equation:\na * x + b = 0, with coeficients a = {0}, b = {1}\nX = {2:F2}", a, b, result);
            }
            else
            {
                Console.WriteLine("Not a valid result, a is equal to 0!");
            }
        }
        else
        {
            Console.WriteLine("Not a valid choice! Please, enter a number from 1 to 3!");
        }
    }
}
