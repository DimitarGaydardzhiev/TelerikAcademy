/*
Problem 3. Static class
• Write a  static class  with a  static method  to calculate the distance between two points in the 3D space.
*/
using System;
namespace StaticClass
{
    class MainProgram
    {
        static void Main()
        {
            Point3D first = new Point3D(1, 2, 3);
            Point3D second = new Point3D(4, 5, 6);

            var result = CalculateDistance.GetDistance(first, second);

            Console.WriteLine(result);
        }
    }
}
