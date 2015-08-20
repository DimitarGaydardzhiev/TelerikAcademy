namespace SumOfDifferences
{
    using System;
    using System.Collections.Generic;
    using Utilities;

    public class SumOfDifferences
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] arr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] numbers = new long[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = long.Parse(arr[i]);
            }

            List<long> differences = Calculator.CalculateDifferences(numbers);
            long sum = 0;

            for (int i = 0; i < differences.Count; i++)
            {
                if (differences[i] % 2 == 1)
                {
                    sum += differences[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}