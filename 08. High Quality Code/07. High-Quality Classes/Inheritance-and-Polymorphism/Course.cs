namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        public Course(string name, string teacherName)
            : this(name)
        {
            this.TeacherName = teacherName;
        }

        public Course(string name, string teacherName, ICollection<string> students)
            : this(name, teacherName)
        {
            foreach (var student in students)
            {
                this.Students.Add(student);
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Course name can not be empty!");
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Teacher name can not be empty!");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            private set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("There must be at least one student in the students list!");
                }

                this.students = value;
            }
        }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            string type = this.GetType().Name;
            string teacherName = string.Format("Teacher = {0}", this.TeacherName);
            string courseName = string.Format("Course name = {0}", this.Name);
            string students = string.Format("Students -> {0}", this.GetStudentsAsString());

            StringBuilder result = new StringBuilder();

            result.AppendLine(type);
            result.AppendLine(teacherName);
            result.AppendLine(courseName);
            result.AppendLine(students);

            return result.ToString().Trim();
        }
    }
}
