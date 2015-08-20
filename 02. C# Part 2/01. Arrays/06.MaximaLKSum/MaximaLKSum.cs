/*
Problem 6. Maximal K sum
Write a program that reads two integer numbers  N  and  K  and an array of  N  elements from the console.
Find in the array those  K  elements that have maximal sum.
*/

using System;

class MaximaLKSum
{
    static void Main()
    {
        Console.Write("Please enter N = ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Please enter K = ");
        int K = int.Parse(Console.ReadLine());

        int[] arr = new int[N];

        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Array [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr); // Sort the array from MIN to MAX Value, starting from [0] to [N]

        for (int i = arr.Length-1; i >= arr.Length-K; i--)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum);
    }
}