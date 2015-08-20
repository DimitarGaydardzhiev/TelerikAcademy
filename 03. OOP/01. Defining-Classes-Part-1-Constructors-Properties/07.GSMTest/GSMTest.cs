/*
Problem 7. GSM test
• Write a class  GSMTest  to test the  GSM  class: 
◦ Create an array of few instances of the  GSM  class.
◦ Display the information about the GSMs in the array.
◦ Display the information about the static property  IPhone4S .
*/
using System;

namespace GSMTest
{
    public class GSMTest
    {
        static void Main()
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
