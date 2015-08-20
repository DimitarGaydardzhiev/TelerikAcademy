

//Problem 9. Trapezoids
//Write an expression that calculates trapezoid's area by given sides  a  and  b  and height  h .

using System;

class Trapezoids
{
    static void Main()
    {
        string sideA;
        Console.WriteLine("Enter side A of the trapezoid: ");
        sideA = Console.ReadLine();

        string sideB;
        Console.WriteLine("Enter side B of the trapezoid: ");
        sideB = Console.ReadLine();

        string heightH;
        Console.WriteLine("Enter the height H of the trapezoid: ");
        heightH = Console.ReadLine();

        double a = double.Parse(sideA);
        double b = double.Parse(sideB);
        double h = double.Parse(heightH);

        double result = ((a + b) / 2) * h;
        Console.WriteLine("The area of the trapezoid is: {0}", result);
    }
}