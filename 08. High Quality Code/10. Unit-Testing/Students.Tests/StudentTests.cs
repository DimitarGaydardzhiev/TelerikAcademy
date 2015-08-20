namespace Students.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        private Student student;

        [TestInitialize]
        public void InitializeStudent()
        {
            this.student = new Student("Ivan Ivanov", 55555);
        }

        [TestMethod]
        public void StudentShouldBeInitialliCreatedWithoutAnException()
        {
            this.student = new Student("Ivan Ivanov", 55555);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedName()
        {
            this.student = new Student("Ivan Ivanov", 55555);
            Assert.AreEqual("Ivan Ivanov", this.student.Name);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedNumber()
        {
            this.student = new Student("Ivan Ivanov", 55555);
            Assert.AreEqual(55555, this.student.Number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrownExceptionWhenNameIsNullOrEmpty()
        {
            this.student = new Student(string.Empty, 55555);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowAnExceptionForTooLowNumber()
        {
            this.student = new Student("Ivan Ivanov", 500);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowAnExceptionForTooHighNumber()
        {
            this.student = new Student("Ivan Ivanov", 999999);
        }

        [TestMethod]

        public void StudentShouldNotThrownAnExceptionWhenJoiningCourse()
        {
            var course = new Course("JavaScipt");
            this.student.JoinCourse(course);
        }

        [TestMethod]

        public void StudentShouldNotThrownAnExceptionWhenLeavingCourse()
        {
            var course = new Course("JavaScipt");
            this.student.JoinCourse(course);
            this.student.LeaveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectToThrowWhenJoiningNullCourse()
        {
            this.student.JoinCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectToThrowWhenLeavingNullCourse()
        {
            this.student.LeaveCourse(null);
        }
    }
}
