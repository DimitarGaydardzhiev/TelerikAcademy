/*
Problem 9. Matrix of Numbers
 * Write a program that reads from the console a positive integer number  n  (1 ≤ n ≤ 20) 
 * and prints a matrix like in the examples below. Use two nested loops.
 */

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Please, enter n= ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n-1; i++)
        {
            for (int j = 0; j <= n-1; j++)
            {
                Console.Write("{0} ", j+i+1);
            }
            Console.WriteLine();
        }
    }
}

