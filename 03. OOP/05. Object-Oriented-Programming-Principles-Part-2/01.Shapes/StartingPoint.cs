/*
Problem 1. Shapes
• Define abstract class  Shape  with only one  abstract  method  CalculateSurface()  and fields  width  and  height .
• Define two new classes  Triangle  and  Rectangle  that implement the  virtual  method 
and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).
• Define class  Square  and suitable constructor so that at initialization  height  must be kept equal to  width  and implement the  CalculateSurface()  method.
• Write a program that tests the behaviour of the  CalculateSurface()  method for different shapes ( Square ,  Rectangle ,  Triangle ) stored in an array.
*/

namespace Shapes
{
    using System;
    using System.Collections.Generic;
    public class StartingPoint
    {
        public static void Main()
        {
            List<Shape> figures = new List<Shape>
            {
                new Rectangle(25, 3.34),
                new Square(5.54),
                new Triangle(3, 4.12)
            };

            for (int i = 0; i < figures.Count; i++)
            {
                Console.WriteLine("{0} Surface is:\n{1:F2}", figures[i].ToString(), figures[i].CalculateSurface());
                Console.WriteLine();
            }
        }
    }
}
