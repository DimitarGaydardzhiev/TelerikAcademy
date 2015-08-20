using System;

namespace SchoolClasses
{
    public class Disciplines: ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExcercises;

        public string Name { get; private set; }
        public int NumberOfLectures { get; private set; }
        public int NumberOfExcercises { get; private set; }


        public string Comment()
        {
            Console.WriteLine("Enter comment for this discipline: ");
            return Console.ReadLine();
        }
    }
}
