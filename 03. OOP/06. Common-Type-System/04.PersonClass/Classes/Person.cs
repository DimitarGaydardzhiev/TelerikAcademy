
namespace PersonClass
{
    using System;
    public class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name;}
            set { this.name = value; }
        }
        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return String.Format("My name is {0}", this.Name);
            }
            else
            {
                return String.Format("My name is {0}, and I am {1} years old", this.Name, this.Age);
            }
        }

    }
}
