/*
Problem 17.* Subset K with sum S
Write a program that reads three integer numbers  N ,  K  and  S  and an array of  N  elements from the console.
Find in the array a subset of  K  elements that have sum  S  or indicate about its absence.
*/
using System;
class SubsetKWithSumS
{
    static void Main()
    {
        Console.Write("Please, enter array lenght N = ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Please, enter subset lenght K = ");
        int K = int.Parse(Console.ReadLine());

        Console.Write("Please, enter sum S = ");
        int S = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        int sum = 0;
        bool flag = false;
        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Array{[0]} = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            for (int j = i+1; j < arr.Length; j++)
            {
                sum += arr[j];
                counter += 2;
                if (sum>S)
                {
                    counter -= 1;
                    sum -= arr[j];
                }
                if (sum<S)
                {
                    counter += 1;
                    continue;
                }
                if (sum==S&&j==K)
                {
                    Console.WriteLine("Yes");
                    flag = true;
                    break;
                }
            }
            counter = 0;
            sum = 0;
        }
        if (flag == false)
        {
            Console.WriteLine("There is no {0} elements that have the sum of {1}", K, S);
        }
    }
}

