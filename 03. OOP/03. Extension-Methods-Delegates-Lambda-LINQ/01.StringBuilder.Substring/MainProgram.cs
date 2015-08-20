
/*
Problem 1. StringBuilder.Substring
• Implement an extension method  Substring(int index, int length)  for the class  StringBuilder  
that returns new  StringBuilder  and has the same functionality as  Substring  in the class  String .
*/

namespace StringBuilder.Substring
{
    using System;
    using System.Text;
    using StringBuilder.Extensions;
    class Program
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 1; i < 10; i++)
            {
                builder.Append(i);
            }

            Console.WriteLine(builder.Substring(1,2));
        }
    }
}
