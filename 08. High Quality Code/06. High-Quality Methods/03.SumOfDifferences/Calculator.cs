namespace Utilities
{
    using System;
    using System.Collections.Generic;

    public static class Calculator
    {
        public static List<long> CalculateDifferences(long[] numbers)
        {
            long absoluteDiff = 0;
            long currentPosition = 0;
            var result = new List<long>();

            for (int i = 1; i < numbers.Length; i++)
            {
                currentPosition = i;
                absoluteDiff = Math.Abs(numbers[i] - numbers[i - 1]);
                result.Add(absoluteDiff);

                if (absoluteDiff % 2 == 1)
                {
                    continue;
                }

                if (absoluteDiff % 2 == 0)
                {
                    i++;
                }
            }

            return result;
        }
    }
}
