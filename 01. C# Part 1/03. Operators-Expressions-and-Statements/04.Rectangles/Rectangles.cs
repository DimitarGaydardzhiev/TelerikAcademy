

//Problem 4. Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        string recWeight;
        string recHeight;

        Console.Write("Enter rectangles's weight: ");
        recWeight = Console.ReadLine();

        Console.Write("Enter rectangles's height: ");
        recHeight = Console.ReadLine();

        decimal Weight = decimal.Parse(recWeight);
        decimal Height = decimal.Parse(recHeight);

        decimal perimeter = (2 * Weight) + (2 * Height);
        decimal area = Weight * Height;

        Console.WriteLine("The perimeter of the rectangle is: {0}\nThe area of the rectangle is: {1}", perimeter, area);


    }
}
