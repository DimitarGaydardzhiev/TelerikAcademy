/*
Problem 4. Maximal sequence
Write a program that finds the maximal sequence of equal elements in an array.
*/
using System;

class MaximalSequence
{
    static void Main()
    {
        string line = Console.ReadLine();

        string[] arrStr = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[arrStr.Length];

        int counter = 1;
        int currentLength = 1;
        int currentNumber = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(arrStr[i]);
        }

        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i]==arr[i+1])
            {
                currentNumber = arr[i];
                counter++;
            }
            else 
            {
                if (counter > currentLength)
                {
                    currentLength = counter;
                    counter = 0;
                }
            }
        }
        for (int i = 0; i < currentLength; i++)
        {
            Console.Write("{0}, ", currentNumber);
        }       
    }
}

