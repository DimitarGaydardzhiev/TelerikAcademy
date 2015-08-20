
namespace AnimalHierarchy
{
    using System;
    public class Kitten : Cat, ISound
    {
        protected const string sex = "female";

        public Kitten(string name, int age)
            :base(name,age, Sex.female)
        {
        }

        public override string Sound()
        {
            return String.Format("miauuuuuu!");
        }
    }
}
