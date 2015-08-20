namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public static class Calculator
    {
        private const int IntValue = 1;
        private const long LongValue = 1L;
        private const float FloatValue = 1.0f;
        private const double DoubleValue = 1.0;
        private const decimal DecimalValue = 1.0m;
        private static Stopwatch stopwatch = new Stopwatch();

        public static void CalculateInteger(int valueCalculatingTo, Operation operation)
        {
            int result = 1;

            stopwatch.Start();
            for (int i = 1; i < valueCalculatingTo; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        result += IntValue;
                        break;
                    case Operation.Subtract:
                        result -= IntValue;
                        break;
                    case Operation.Multiply:
                        result *= IntValue;
                        break;
                    case Operation.Divide:
                        result /= IntValue;
                        break;
                    default: throw new ArgumentException("Invalid operation!");
                }
            }

            stopwatch.Stop();
            Console.WriteLine("{0} time -> {1}", operation, stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }

        public static void CalculateLong(long valueCalculatingTo, Operation operation)
        {
            long result = 1L;

            stopwatch.Start();
            for (int i = 1; i < valueCalculatingTo; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        result += LongValue;
                        break;
                    case Operation.Subtract:
                        result -= LongValue;
                        break;
                    case Operation.Multiply:
                        result *= LongValue;
                        break;
                    case Operation.Divide:
                        result /= LongValue;
                        break;
                    default: throw new ArgumentException("Invalid operation!");
                }
            }

            stopwatch.Stop();
            Console.WriteLine("{0} time -> {1}", operation, stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }

        public static void CalculateDouble(double valueCalculatingTo, Operation operation)
        {
            double result = 1.0d;

            stopwatch.Start();
            for (int i = 1; i < valueCalculatingTo; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        result += DoubleValue;
                        break;
                    case Operation.Subtract:
                        result -= DoubleValue;
                        break;
                    case Operation.Multiply:
                        result *= DoubleValue;
                        break;
                    case Operation.Divide:
                        result /= DoubleValue;
                        break;
                    default: throw new ArgumentException("Invalid operation!");
                }
            }

            stopwatch.Stop();
            Console.WriteLine("{0} time -> {1}", operation, stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }

        public static void CalculateFloat(float valueCalculatingTo, Operation operation)
        {
            float result = 1.0f;

            stopwatch.Start();
            for (int i = 1; i < valueCalculatingTo; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        result += FloatValue;
                        break;
                    case Operation.Subtract:
                        result -= FloatValue;
                        break;
                    case Operation.Multiply:
                        result *= FloatValue;
                        break;
                    case Operation.Divide:
                        result /= FloatValue;
                        break;
                    default: throw new ArgumentException("Invalid operation!");
                }
            }

            stopwatch.Stop();
            Console.WriteLine("{0} time -> {1}", operation, stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }

        public static void CalculateDecimal(decimal valueCalculatingTo, Operation operation)
        {
            decimal result = 1.0m;

            stopwatch.Start();
            for (int i = 1; i < valueCalculatingTo; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        result += DecimalValue;
                        break;
                    case Operation.Subtract:
                        result -= DecimalValue;
                        break;
                    case Operation.Multiply:
                        result *= DecimalValue;
                        break;
                    case Operation.Divide:
                        result /= DecimalValue;
                        break;
                    default: throw new ArgumentException("Invalid operation!");
                }
            }

            stopwatch.Stop();
            Console.WriteLine("{0} time -> {1}", operation, stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }
    }
}
