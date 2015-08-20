

namespace Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Student
    {
        private string firstName;
        private string lastName;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public static void SortNames (Student[] students)
        {
            var result = from student in students
                         where (student.firstName.ToLower().ToCharArray(0, 1))[0] < (student.lastName.ToLower().ToCharArray(0, 1))[0]
                         select student;

            foreach (var studnet in result)
            {
                Console.WriteLine(studnet.firstName + " " + studnet.lastName);
            }
        }
    }
}
