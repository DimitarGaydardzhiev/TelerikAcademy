namespace Students
{
    using System;

    public class Student
    {
        private const int MinStudentNumber = 10000;
        private const int MaxStudentNumber = 99999;
        private string name;
        private int number;

        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }

        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value < MinStudentNumber || value > MaxStudentNumber)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Student number must be in the range {0} : {1}", MinStudentNumber, MaxStudentNumber));
                }

                this.number = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "Cannot be null or empty");
                }

                this.name = value;
            }
        }

        public void JoinCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null");
            }

            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null");
            }

            course.RemoveStudent(this);
        }
    }
}
