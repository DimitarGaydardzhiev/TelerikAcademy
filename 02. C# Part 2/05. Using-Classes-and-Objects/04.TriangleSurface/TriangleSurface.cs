/*
Problem 4. Triangle surface
Write methods that calculate the surface of a triangle by given: 
◦ Side and an altitude to it;
◦ Three sides;
◦ Two sides and an angle between them;

• Use  System.Math .
*/
using System;
class TriangleSurface
{
    static double SideAndAttitude (double side, double attitude)
    {
        double result = (side * attitude) / 2;
        return result;
    }
    static double ThreeSides(double sideA, double sideB, double sideC)
    {
        double semiperimeter = (sideA + sideB + sideC) / 2;
        double result = Math.Sqrt(semiperimeter * (semiperimeter - sideA) *(semiperimeter - sideB) * (semiperimeter - sideC));
        return result;
    }
    static double SidesAndAngle(double sideA, double sideB, double angle)
    {
        angle = angle * (Math.PI / 180); //The angle is in radians by default, so this is turning it into degrees
        double result = (sideA * sideB * Math.Sin(angle)) / 2;
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Please chose a method for calculating the triangle surface: ");
        Console.WriteLine("1. Calculate with side and an altitude to it");
        Console.WriteLine("2. Calculate with three sides");
        Console.WriteLine("3. Calculate with two sides and an angle between them");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Side = ");
            int side = int.Parse(Console.ReadLine());

            Console.Write("Attitude = ");
            int attitude = int.Parse(Console.ReadLine());

            double result = SideAndAttitude(side, attitude);

            Console.WriteLine("Surface = {0}", result);
        }
        else if (choice == 2)
        {
            Console.Write("Side a = ");
            int sideA = int.Parse(Console.ReadLine());

            Console.Write("Side b = ");
            int sideB = int.Parse(Console.ReadLine());

            Console.Write("Side c = ");
            int sideC = int.Parse(Console.ReadLine());

            double result = ThreeSides(sideA, sideB, sideC);

            Console.WriteLine("Surface = {0}", result);
        }
        else if (choice == 3)
        {
            Console.Write("Enter first side = ");
            int firstSide = int.Parse(Console.ReadLine());

            Console.Write("Enter second side = ");
            int secondSide = int.Parse(Console.ReadLine());

            Console.Write("Enter angle between the two sides = ");
            int angle = int.Parse(Console.ReadLine());

            double result = SidesAndAngle(firstSide, secondSide, angle);

            Console.WriteLine("Surface = {0}", result);
        }
        else
        {
            Console.WriteLine("Not a valid choice!");
        }
    }
}

