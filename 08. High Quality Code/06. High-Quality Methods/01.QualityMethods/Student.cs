namespace Person
{
    using System;

    public class Student
    {
        public Student(string firstName, string lastName, string city, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.BirthDate = birthDate;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime firstStudentDate = this.BirthDate;
            DateTime secondStudentDate = otherStudent.BirthDate;

            bool isOlder = false;

            if (firstStudentDate > secondStudentDate)
            {
                isOlder = true;
            }

            return isOlder;
        }
    }
}
