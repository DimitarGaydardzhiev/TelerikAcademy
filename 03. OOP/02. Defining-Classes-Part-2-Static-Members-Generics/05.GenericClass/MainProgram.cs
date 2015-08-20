/*
Problem 5. Generic class
• Write a generic class  GenericList<T>  that keeps a list of elements of some parametric type  T .
• Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
• Implement methods for adding element, accessing element by index, removing element by index, 
inserting element at given position, clearing the list, finding element by its value and  ToString() .
• Check all input parameters to avoid accessing elements at invalid positions.
*/
using System;

namespace GenericClass
{
    class MainProgram
    {
        static void Main()
        {
            GenericList<int> a = new GenericList<int>(34);

            //Console.WriteLine(a.Capacity);
            a.AddElement(6);
            a.AddElement(7);
            a.AddElement(8);
            //Console.WriteLine(a.Count);

            //Console.WriteLine(a.GetElement(2));

            a.RemoveElement(2);

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a.GetElement(i));
            }

            Console.WriteLine();
            a.InsertElement(24, 5);

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a.GetElement(i));
            }
            Console.WriteLine();

            //a.Clear();
            //for (int i = 0; i < a.Count; i++)
            //{
            //    Console.WriteLine(a.GetElement(i));
            //}

            Console.WriteLine();

            
            Console.WriteLine(a.GetIndexOf(7));
        }
    }
}
