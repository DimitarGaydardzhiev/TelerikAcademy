namespace Print
{
    using System;

    public static class Printer
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double maxNumber = double.MinValue;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > maxNumber)
                {
                    maxNumber = arr[i];
                }
            }

            this.PrintNumber("Max", maxNumber);

            double minNumber = double.MaxValue;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < minNumber)
                {
                    minNumber = arr[i];
                }
            }

            this.PrintNumber("Min", minNumber);

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            this.PrintAverage(sum, count);
        }

        private double PrintAverage(double sum, int count)
        {
            double result = sum / count;
            return result;
        }

        private void PrintNumber(string maxOrMinMessage, double number)
        {
            Console.WriteLine("The {0} number in the array is: ", maxOrMinMessage, number);
        }
    }
}
