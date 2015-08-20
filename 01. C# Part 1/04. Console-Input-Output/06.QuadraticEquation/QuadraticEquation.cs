//Problem 6. Quadratic equation
//Write a program that reads the coeficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots)

using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Write the coeficients of the quadratic equation:");
        Console.Write("a= ");
        string a = Console.ReadLine();

        Console.Write("b=");
        string b = Console.ReadLine();

        Console.Write("c=");
        string c = Console.ReadLine();

        double coefA = double.Parse(a);
        double coefB = double.Parse(b);
        double coefC = double.Parse(c);

        double desk = (Math.Pow(coefB, 2)) - (4 * coefA * coefC);
        double x1 = (-coefB - Math.Sqrt(desk)) / (2 * coefA);
        double x2 = (-coefB + Math.Sqrt(desk)) / (2 * coefA);

        if (desk < 0)
        {
            Console.WriteLine("The equation doesn't have real roots");
        }
        else
        {
            if (desk == 0)
            {
                Console.WriteLine("The roots of the quadratic equation are:\nx1= x2= {0}", x1);
            }
            else
            {
                Console.WriteLine("The roots of the quadratic equation are:\nx1= {0}\nx2= {1}", x1, x2);
            }
        }
    }
}

