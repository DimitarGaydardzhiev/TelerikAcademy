/*
Problem 6. Divisible by 7 and 3
• Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/
namespace DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        public static void Print (IEnumerable<bool> selected, int[] array)
        {
            int counter = 0;

            foreach (var item in selected)
            {
                if (item == true)
                {
                    Console.WriteLine(array[counter]);
                }
                counter++;
            }
        }
        static void Main()
        {
            int[] array = new int[10] { 5, 7, 8, 12, 14, 3, -90, -99, 100, 1 };

            IEnumerable<bool> select = array.Select(x => x % 3 == 0 || x % 7 == 0);

            Console.WriteLine("The numbers divisible by 3 or 7 are:");
            Print(select, array);
            Console.WriteLine();

            Console.WriteLine("Using LINQ: ");
            var selectLINQ = from number in array
                             where (number % 3 == 0 || number % 7 == 0)
                             select number;

            foreach (var number in selectLINQ)
            {
                Console.WriteLine(number);
            }
        }
    }
}
