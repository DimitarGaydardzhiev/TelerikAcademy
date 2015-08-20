/*
Problem 2. IEnumerable extensions
• Implement a set of extension methods for  IEnumerable<T>  
that implement the following group functions: sum, product, min, max, average.
*/
namespace IEnumerableExtensions
{
    using System;
    using IEnumerableExtensions.Extensions;
    class MainProgram
    {
        static void Main()
        {
            
            int[] testArray = new int[5] { 1, -2, 3, 5, 10 };
            
            //Sum test
            Console.WriteLine("Sum: {0}", testArray.Sum<int>());
            Console.WriteLine();

            //Product test
            Console.WriteLine("Product: {0}", testArray.Product<int>());
            Console.WriteLine();

            //Min test
            Console.WriteLine("Min value: {0}", testArray.Min<int>());
            Console.WriteLine();

            //Max test
            Console.WriteLine("Max value: {0}", testArray.Max<int>());
            Console.WriteLine();
            
            //Average test
            Console.WriteLine("Average value: {0:F2}", testArray.Average<int>());
        }
    }
}
