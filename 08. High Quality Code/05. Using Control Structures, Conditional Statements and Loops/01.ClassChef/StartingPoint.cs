namespace Cook
{
    using System;
    using CookingTools;

    public class StartingPoint
    {
        public static void Main()
        {
            Chef someChef = new Chef();
            Bowl newBowl = someChef.Cook();

            Console.WriteLine(newBowl);
        }
    }
}
