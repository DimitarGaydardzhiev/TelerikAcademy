

//Problem 10. Fibonacci Numbers
//Write a program that reads a number  n  and prints on the console the first  n  members of the Fibonacci sequence 
//(at a single line, separated by comma and space -  , ) :  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … .

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter number:");
        int members = int.Parse(Console.ReadLine());

        int firstN = 0;
        int secondN = 1;
        int sumNext = 0;

        Console.Write(firstN + " " + secondN + " ");

        for (int i = 0; i < members-2; i++)
        {
           
            sumNext = firstN + secondN;
            firstN = secondN;
            secondN = sumNext;
            Console.Write(sumNext + " ");
            
        }
        Console.WriteLine();
    }
}