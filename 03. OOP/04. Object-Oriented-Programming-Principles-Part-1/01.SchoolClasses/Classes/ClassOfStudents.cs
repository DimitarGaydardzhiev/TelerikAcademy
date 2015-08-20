

namespace SchoolClasses
{
    using System;
    public class ClassOfStudents: ICommentable
    {
        private string classID;
        private Teacher[] setOfTeachers;
        public string ClassID { get; private set; }

        public Teacher[] SetOfTeachers { get; private set; }


        public string Comment()
        {
            Console.WriteLine("Enter comment for this class: ");
            return Console.ReadLine();
        }
    }
}
