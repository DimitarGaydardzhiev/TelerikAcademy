
//Problem 11. Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers  p  exist between them such that the reminder of the division by  5  is  0 .

using System;
class NumbersDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second number: ");
        int n2 = int.Parse(Console.ReadLine());

        for (int i = n1; i <= n2; i++)
        {
            if (i%5==0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
