
namespace StudentClass
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone  { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Speciality Speciality { get; set; }
        public University University { get; set; }
        public Facility Facility { get; set; }

        public Student(string firstName, string middleName, string lastName, int SSN, string permanentAddress,
            string mobilePhone, string eMail, string course, Speciality speciality, University university, Facility facility )
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = eMail;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Facility = facility;
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student==null)
            {
                return false;
            }
            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.MiddleName,student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName,student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            if (!Object.Equals(this.PermanentAddress,student.PermanentAddress))
            {
                return false;
            }
            if (!Object.Equals(this.MobilePhone,student.MobilePhone))
            {
                return false;
            }
            if (!Object.Equals(this.Email, student.Email))
            {
                return false;
            }
            if (!Object.Equals(this.Course, student.Course))
            {
                return false;
            }
            if (!Object.Equals(this.Speciality, student.Speciality))
            {
                return false;
            }
            if (!Object.Equals(this.University, student.University))
            {
                return false;
            }
            if (!Object.Equals(this.Facility, student.Facility))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Student()
        {

        }
        public override string ToString()
        {
            return string.Format("My name is {0}, {1}, {2} and i live in {3}. I study in the {4}, facility of {5}, with SSN {6}. My speciality is {7}, and now i am studing {8}.\nTo contact me use: Email: {9}, mobile phone: {10}",
                FirstName, MiddleName, LastName, PermanentAddress, University, Facility, SSN, Speciality, Course, Email, MobilePhone);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        //Problem 2. IClonable• Add implementations of the  ICloneable  interface. 
        //The  Clone()  method should deeply copy all object's fields into a new object of type  Student .

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            Student clonedStudent = new Student();

            clonedStudent.FirstName = this.FirstName;
            clonedStudent.MiddleName = this.MiddleName;
            clonedStudent.LastName = this.LastName;
            clonedStudent.SSN = this.SSN;
            clonedStudent.PermanentAddress = this.PermanentAddress;
            clonedStudent.MobilePhone = clonedStudent.MobilePhone;
            clonedStudent.Email = this.Email;
            clonedStudent.Course = this.Course;
            clonedStudent.Speciality = this.Speciality;
            clonedStudent.University = this.University;
            clonedStudent.Facility = this.Facility;

            return clonedStudent;
        }

        //Problem 3. Implement the  IComparable<Student>  interface to compare students by names 
        //(as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).



        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName.CompareTo(otherStudent.FirstName)!=0)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }
            if (this.MiddleName.CompareTo(otherStudent.MiddleName)!=0)
            {
                return this.MiddleName.CompareTo(otherStudent.MiddleName);
            }
            if (this.LastName.CompareTo(otherStudent.LastName)!=0)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }
            else
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }
        }
    }
}
