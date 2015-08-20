/*
Problem 4. Binary search
Write a program, that reads from the console an array of  N  integers and an integer  K , 
sorts the array and using the method Array.BinSearch()  finds the largest number in the array which is ≤  K .
*/
using System;
class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter size of the array N = ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
 
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Array[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter K = ");
        int K = int.Parse(Console.ReadLine());

        Array.Sort(arr);

        int number = Array.BinarySearch(arr, K); //if the number is not in the array, the method returns a negative value of number

        if (number>0)
        {
            Console.WriteLine("The largest element is equal to K = {0}", arr[number]);
        }
        else
        {
            if (K < arr[0])
            {
                Console.WriteLine("No such number!");
            }
            if (K > arr[N-1])
            {
                Console.WriteLine("The element K = {0} is not in the array, the biggest number befre it is: {1}", K, arr[N-1]);
            }
        }
        
    }
}

