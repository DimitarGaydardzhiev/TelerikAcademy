

//Problem 10. Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle  K({1, 1}, 1.5)  and out of the rectangle  R(top=1, left=-1, width=6, height=2) .

using System;

class PointInsideOrOutside
{
    static void Main()
    {
        string x;
        Console.WriteLine("Enter X coordinate: ");
        x = Console.ReadLine();

        double X = double.Parse(x);

        string y;
        Console.WriteLine("Enter Y coordinate: ");
        y = Console.ReadLine();

        double Y = double.Parse(y);

        double R = 1.5;

        double xDifferenceC = X - 1;
        double yDifferenceC = Y - 1;

        bool resultCircle = ((Math.Pow(xDifferenceC, 2)) + (Math.Pow(yDifferenceC, 2))) <= (Math.Pow(R, 2));

        double xMaxRec = 5;
        double xMinRec = -1;
        double yMaxRec = 1;
        double yMinRec = -1;

        bool checkX = X <= xMaxRec && X >= xMinRec;
        bool checkY = Y <= yMaxRec && Y >= yMinRec;

        bool resultRec = checkX && checkY;

        bool result = resultCircle && !resultRec;

        Console.WriteLine("Your point is inside the figures: {0}", result);
    }
}

