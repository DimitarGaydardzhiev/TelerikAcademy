
namespace SchoolClasses
{
    using System;

    public abstract class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name = Name;
            }
            private set
            {
                name = value;
            }
        }
    }
}
