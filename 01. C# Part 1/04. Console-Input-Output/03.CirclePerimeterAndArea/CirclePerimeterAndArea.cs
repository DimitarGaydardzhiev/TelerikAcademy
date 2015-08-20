

//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius  r  of a circle and prints its perimeter and area formatted with  2  digits after the decimal point.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter the radius of the circle: ");
        string R = Console.ReadLine();
        double radius = double.Parse(R);

        double perimeter = 2*Math.PI*radius;

        double area = Math.PI * (Math.Pow(radius, 2));

        Console.WriteLine("The perimeter of the circle is: {0:F2}\nThe area of the circle is: {1:F2}", perimeter, area);

    }
}
