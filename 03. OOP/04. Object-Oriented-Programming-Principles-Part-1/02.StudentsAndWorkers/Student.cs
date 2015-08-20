

namespace StudentsAndWorkers
{
    using System;
    using System.Linq;
    public class Student : Human
    {
        private int grade;

        public int Grade { get; private set; }
        public Student(string firstName, string lastName, int grade)
            :base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
