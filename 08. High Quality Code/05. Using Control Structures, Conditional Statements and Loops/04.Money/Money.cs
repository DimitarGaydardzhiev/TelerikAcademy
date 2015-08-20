namespace Money
{
    using System;

    public class Money
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfPaperSheets = int.Parse(Console.ReadLine());
            double paperBoxPrice = double.Parse(Console.ReadLine());

            double numberOfSheets = CalculateSheets(numberOfStudents, numberOfPaperSheets);

            const double NumberOfSheetesInABox = 400.0;
            double numberOfBoxes = numberOfSheets / NumberOfSheetesInABox;

            double result = CalculateMoney(numberOfBoxes, paperBoxPrice);

            Console.WriteLine("{0:F3}", result);
        }

        public static double CalculateMoney(double numberOfBoxes, double price)
        {
            double money = numberOfBoxes * price;

            return money;
        }

        public static double CalculateSheets(double students, double sheets)
        {
            double result = students * sheets;

            return result;
        }
    }
}
