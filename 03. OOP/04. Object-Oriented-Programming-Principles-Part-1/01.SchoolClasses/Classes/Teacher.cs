
namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    public class Teacher : Person, ICommentable
    {
        private List<string> setOfDisciplines;
        public List<string> SetOfDisciplines { get; private set; }

        public string Comment()
        {
            Console.WriteLine("Enter comment for this teacher: ");
            return Console.ReadLine();
        }
    }
}
