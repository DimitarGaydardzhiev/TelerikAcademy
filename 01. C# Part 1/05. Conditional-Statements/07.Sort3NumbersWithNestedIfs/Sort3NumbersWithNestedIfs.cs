

//Problem 7. Sort 3 Numbers with Nested Ifs
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//◦ Use nested  if  statements.


using System;
class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Please enter 3 numbers: ");

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (b >= c&&c<=a)
            {
                Console.WriteLine("{0}, {1}, {2}",a,b,c);
            }
            else if (b <= c && c <= a)
            {
                Console.WriteLine("{0}, {1}, {2}", a, c, b);
            }
        }
        if (b > a)
        {
            if (a >= c&&c<=b)
            {
                Console.WriteLine("{0}, {1}, {2}", b, a, c);
            }
            else if (a <= c && c <= b)
            {
                Console.WriteLine("{0}, {1}, {2}", b, c, a);
            }
        }
        if (c > a)
        {
            if (a >= b&&b<=c)
            {
                Console.WriteLine("{0}, {1}, {2}", c, a, b);
            }
            else if (a<=b&&b<=c)
            {
                Console.WriteLine("{0}, {1}, {2}", c, b, a);
            }
        }
        if (a==b&&a==c)
        {
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
        }
    }
}
