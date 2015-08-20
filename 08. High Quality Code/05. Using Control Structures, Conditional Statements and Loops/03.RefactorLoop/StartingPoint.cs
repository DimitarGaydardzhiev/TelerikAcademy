namespace RefactorLoop
{
    using System;

    public class StartingPoint
    {
        public static void Main()
        {
            const int MaxLength = 100;
            const int ExpectedValue = 666;

            int[] array = new int[MaxLength];
            FoundValue(array, ExpectedValue);
        }

        public static void FoundValue(int[] array, int expectedValue)
        {
            bool isFound = false;

            for (int i = 0; i <= array.Length; i++)
            {
                int currentValue = array[i];
                bool isRound = i % 10 == 0;

                if (isRound && currentValue == expectedValue)
                {
                    isFound = true;
                }
                else
                {
                    Console.WriteLine(currentValue);
                }
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}