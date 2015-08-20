namespace Utilities
{
    using System;
    using System.Collections.Generic;

    public static class Calculator
    {
        public static int SumInDecimalSystem(string[] input)
        {
            List<int> numbers = new List<int>();
            int currentNumber = 0;
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                foreach (var letter in input[i])
                {
                    currentNumber = letter - 97;
                    numbers.Add(currentNumber);
                }

                numbers.Reverse();

                for (int j = 0; j < numbers.Count; j++)
                {
                    numbers[j] *= (int)Math.Pow(19, j);
                    result += numbers[j];
                }

                numbers.Clear();
            }

            return result;
        }

        public static List<int> CalculateCodesIn19BasedSystem(int sum)
        {
            sum = Convert.ToInt32(sum);
            int currentResult = sum;
            int code = 0;
            List<int> codesIn19BasedSystem = new List<int>();

            do
            {
                code = currentResult % 19;
                codesIn19BasedSystem.Add(code);
                currentResult /= 19;
            } while (currentResult != 0);

            return codesIn19BasedSystem;
        }
    }
}
