/*
Problem 2. Compare arrays
Write a program that reads two  integer  arrays from the console and compares them element by element.
*/
using System;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int[] firstArr = new int[n];
        int[] secondArr = new int[m];

        bool equal = false;

        for (int i = 0; i < n; i++)
        {
            firstArr[i]=int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < m; i++)
		{
			secondArr[i]=int.Parse(Console.ReadLine());
		}
        if (n==m)
        {
            for (int i = 0; i < m; i++)
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

