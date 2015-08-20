using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class Program
    {
        static void Main()
        {
            GSM gsm = new GSM("Lumia", "Nokia");

            Console.WriteLine(gsm.ToString());
        }
    }
}
