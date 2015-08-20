
namespace SchoolClasses
{
    using System;
    public class Student : Person, ICommentable
    {
        public int ID { get; private set; }

        public string Comment()
        {
            Console.WriteLine("Enter comment for this student: ");
            return Console.ReadLine();
        }
    }
}
