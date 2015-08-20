

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Sex sex;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public Sex Sex
        {
            get
            {
                return sex;
            }
        }
        public Animal(string name, int age, Sex sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }


        public virtual string Sound()
        {
            return String.Format("Hi, I am animal!");
        }
        public static double AverageAge(Animal[] animal)
        {
            var age = animal.Select(x => x.Age);
            double result = age.Average();
            return result;
        }
    }
}
