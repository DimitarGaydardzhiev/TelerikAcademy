/*
Problem 4. Appearance count
Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
*/
using System;
class AppearanceCount
{

    static int[] initializeArray()
    {
        Console.Write("Enter, number of elements = ");
        int numberOfElements = int.Parse(Console.ReadLine());

        int[] arr = new int[numberOfElements];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Array[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }

    static int countNumbers(int number, int[] arr)
    {
        int counter = 0;
        int bestElemet = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                counter++;
            }
            if (counter > bestElemet)
	         {
		         bestElemet = counter;
	         }     
        }
        return bestElemet;
    }
    static void Main()
    {
        Console.Write("Enter a number to look for: ");
        int N = int.Parse(Console.ReadLine());
        int[] arr = initializeArray();
        int result = countNumbers(N, arr);

        Console.WriteLine("The number {0} appears {1} times in the array", N, result);

    }
}

