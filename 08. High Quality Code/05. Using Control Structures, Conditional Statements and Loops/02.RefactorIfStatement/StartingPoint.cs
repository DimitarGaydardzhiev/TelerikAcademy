namespace RefactorIfStatement
{
    using System;

    public class StartingPoint
    {
        public static void Main()
        {
            Potato potato = new Potato();
            bool notPeeled = !potato.IsPeeled;
            bool notRotten = !potato.IsRotten;

            if (potato != null)
            {
                if (notPeeled && notRotten)
                {
                    potato.Cook();
                }
            }

            const int MinX = 10;
            const int MaxX = 20;

            const int MinY = 15;
            const int MaxY = 35;

            int x = 5;
            int y = 7;

            bool shouldBeCellVisited = true;

            if (shouldBeCellVisited && IsInRange(x, MinX, MaxX) && IsInRange(y, MinY, MaxY))
            {
                VisitCell();
            }
        }

        public static void VisitCell()
        {
            Console.WriteLine("The cell is visited!");
        }

        public static bool IsInRange(int value, int min, int max)
        {
            bool isInRange = min <= value && value <= max;

            return isInRange;
        }
    }
}
