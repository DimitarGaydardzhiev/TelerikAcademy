using System;

namespace CallHistoryTest
{
    public class GSMTest
    {
        static void Test()
        {
            GSM[] gsmArr = new GSM[3]
            {
            new GSM("Lumia ", " Nokia ", 850, " Pesho"),
            new GSM("Lumia925 ", " Nokia ", 450, " Gosho"),
            new GSM("3310 ", " Nokia ", 50, " Ivan"),
            };

            foreach (GSM item in gsmArr)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Apple phone: ");
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
