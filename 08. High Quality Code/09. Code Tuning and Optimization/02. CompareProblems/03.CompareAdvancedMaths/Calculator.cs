namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    public static class Calculator
    {
        private static Stopwatch stopwatch = new Stopwatch();

        public static void FloatCalculations(float value, MathOperation operation)
        {
            float result = 0.0f;

            stopwatch.Start();
            switch (operation)
            {
                case MathOperation.SquareRoot: result = (float)Math.Sqrt(value);
                    break;
                case MathOperation.NaturalLogarithm: result = (float)Math.Log(value, Math.E);
                    break;
                case MathOperation.Sinus: result = (float)Math.Sin(value);
                    break;
                default: throw new ArgumentException("Invalid operation!");
            }

            stopwatch.Stop();
            Console.WriteLine("{0} time -> {1}", operation, stopwatch.Elapsed);
            stopwatch.Reset();
        }

        public static void DoubleCalculations(double value, MathOperation operation)
        {
            double result = 0.0;

            stopwatch.Start();
            switch (operation)
            {
                case MathOperation.SquareRoot: result = Math.Sqrt(value);
                    break;
                case MathOperation.NaturalLogarithm: result = Math.Log(value, Math.E);
                    break;
                case MathOperation.Sinus: result = Math.Sin(value);
                    break;
                default: throw new ArgumentException("Invalid operation!");
            }

            stopwatch.Stop();
            Console.WriteLine("{0} time -> {1}", operation, stopwatch.Elapsed);
            stopwatch.Reset();
        }

        public static void DecimalCalculations(decimal value, MathOperation operation)
        {
            decimal result = 0.0m;

            stopwatch.Start();
            switch (operation)
            {
                case MathOperation.SquareRoot: result = (decimal)Math.Sqrt((double)value);
                    break;
                case MathOperation.NaturalLogarithm: result = (decimal)Math.Log((double)value, Math.E);
                    break;
                case MathOperation.Sinus: result = (decimal)Math.Sin((double)value);
                    break;
                default: throw new ArgumentException("Invalid operation!");
            }

            stopwatch.Stop();
            Console.WriteLine("{0} time -> {1}", operation, stopwatch.Elapsed);
            stopwatch.Reset();
        }
    }
}
