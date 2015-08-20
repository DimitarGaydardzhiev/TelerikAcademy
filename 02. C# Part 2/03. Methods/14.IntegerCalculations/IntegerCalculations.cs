/*
Problem 14. Integer calculations
Write methods to calculate  minimum ,  maximum ,  average ,  sum  and  product  of given set of integer numbers.
• Use variable number of arguments.
*/
using System;
using System.Linq;
class IntegerCalculations
{
    static int[] InitializeArray(string line)
    {
        string[] arrStr = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[arrStr.Length];

        for (int i = 0; i < arrStr.Length; i++)
        {
            arr[i] = int.Parse(arrStr[i]);
        }
        return arr;
    }
    static int Minimum(params int[] numbers)
    {
        int result = numbers.Min();
        return result;
    }
    static int Maximum(params int[] numbers)
    {
        int result = numbers.Max();
        return result;
    }
    static double Average(params int[] numbers)
    {
        double result = numbers.Average();
        return result;
    }
    static int Sum(params int[] numbers)
    {
        int result = numbers.Sum();
        return result;
    }
    static int Product(params int[] numbers)
    {
        int result = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            result *= numbers[i];
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Choose from the list, what do you want to calculate:");
        Console.WriteLine("1. Calculate minimum value");
        Console.WriteLine("2. Calculate maximum value");
        Console.WriteLine("3. Calculate average value");
        Console.WriteLine("4. Calculate sum value");
        Console.WriteLine("5. Calculate product value");
        int choiceNumber = int.Parse(Console.ReadLine());

        if (choiceNumber == 1)
        {
            Console.Write("Enter numbers: ");
            string line = Console.ReadLine();
            int[] arr = InitializeArray(line);
            int result = Minimum(arr);
            Console.WriteLine("The average value is: {0}", result);
        }
        else if (choiceNumber == 2)
        {
            Console.Write("Enter numbers: ");
            string line = Console.ReadLine();
            int[] arr = InitializeArray(line);
            int result = Maximum(arr);
            Console.WriteLine("The average value is: {0}", result);
        }
        else if (choiceNumber == 3)
        {
            Console.Write("Enter numbers: ");
            string line = Console.ReadLine();
            int[] arr = InitializeArray(line);
            double result = Average(arr);
            Console.WriteLine("The average value is: {0:F2}", result);
        }
        else if (choiceNumber == 4)
        {
            Console.Write("Enter numbers: ");
            string line = Console.ReadLine();
            int[] arr = InitializeArray(line);
            int result = Sum(arr);
            Console.WriteLine("The average value is: {0}", result);
        }
        else if (choiceNumber == 5)
        {
            Console.Write("Enter numbers: ");
            string line = Console.ReadLine();
            int[] arr = InitializeArray(line);
            int result = Product(arr);
            Console.WriteLine("The average value is: {0}", result);
        }
        else
        {
            Console.WriteLine("Not a valide choice!");
        }
    }
}

