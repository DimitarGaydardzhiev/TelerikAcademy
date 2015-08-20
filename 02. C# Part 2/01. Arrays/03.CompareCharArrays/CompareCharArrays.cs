/*
Problem 3. Compare char arrays
Write a program that compares two  char  arrays lexicographically (letter by letter).
 */
using System;

class CompareCharArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        bool equal = false;

        char[] firstArr = new char[n];
        char[] secondArr = new char[m];

        for (int i = 0; i < n; i++)
        {
            firstArr[i]=char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < m; i++)
		{
            secondArr[i] = char.Parse(Console.ReadLine());
		}

        if (n==m)
        {
            for (int i = 0; i < n; i++)
            {
                if (firstArr[i]==secondArr[i])
                {
                    equal = true;
                }
                else
                {
                    equal = false;
                    break;
                }
            }
            Console.WriteLine("The arrays are equal?: {0}", equal);
        }
        else
        {
            Console.WriteLine("The arrays are equal?: {0}", equal);
        }
    }
}
