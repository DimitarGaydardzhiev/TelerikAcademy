/*
Problem 10. Odd and Even Product
 * You are given  n  integers (given in a single line, separated by a space).
• Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
• Elements are counted from  1  to  n , so the first element is odd, the second is even, etc.
*/
using System;
class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Please, enter numbers: ");
        string[] numbers;
        numbers = Console.ReadLine().Split();
        int productOdd = 1;
        int productEven = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i%2==0)
            {
                productOdd *= Convert.ToInt32(numbers[i]);
            }
            else
            {
                productEven *= Convert.ToInt32(numbers[i]);
            }
        }
        if (productOdd==productEven)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

