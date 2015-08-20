

namespace Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
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

        public static void SortByAge (Student[] students)
        {
            var result = from student in students
                         where (student.age >= 18 && student.age <= 24)
                         select student;

            foreach (var studnet in result)
            {
                Console.WriteLine(studnet.firstName + " " + studnet.lastName + " " + studnet.age);
            }
        }

        public static void SortByFirstAndLastName (Student[] students)
        {
            var result = students.OrderByDescending(x => x.firstName)
                .ThenByDescending(y => y.lastName);

            foreach (var student in result)
            {
                Console.WriteLine(student.firstName + " " + student.lastName);
            }
        }

        public static void SortByFirstAndLastNameLINQ(Student[] students)
        {
            var result = from student in students
                         orderby student.firstName descending,
                         student.lastName descending
                         select student;
                        

            foreach (var student in result)
            {
                Console.WriteLine(student.firstName + " " + student.lastName);
            }
        }
    }
}
