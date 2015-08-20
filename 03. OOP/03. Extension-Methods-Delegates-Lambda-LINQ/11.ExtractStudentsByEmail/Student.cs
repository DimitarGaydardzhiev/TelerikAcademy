
namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentGroupsExtensions.Extensions;
    public class Student
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public long Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        //Constructors
        public Student(string firstName, string lastName, int fN, long tel, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public static void SelectStudents(List<Student> students, int groupNumber)
        {
            var result = students.Where(st => st.GroupNumber == groupNumber)
                .OrderBy(st => st.FirstName)
                .Select(st => st);

            Console.WriteLine("Students from group number {0} are: ", groupNumber);
            Console.WriteLine();
            foreach (var student in result)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }

    }
}
