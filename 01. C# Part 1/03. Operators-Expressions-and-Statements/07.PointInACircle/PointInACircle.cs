
//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle  K({0, 0}, 2) .

using System;

class PointInACircle
{
    static void Main()
    {
        string x;
        Console.WriteLine("Enter X coordinate: ");
        x = Console.ReadLine();

        double newX = double.Parse(x);

        string y;
        Console.WriteLine("Enter Y coordinate: ");
        y = Console.ReadLine();

        double newY = double.Parse(y);

        sbyte R = 2;

        bool result = ((Math.Pow(newX,2)) + (Math.Pow(newY,2))) <= (Math.Pow(R,2));

        Console.WriteLine("Your point is inside the circle with equation x^2 + y^2 = 4: {0}", result);

    }
}

