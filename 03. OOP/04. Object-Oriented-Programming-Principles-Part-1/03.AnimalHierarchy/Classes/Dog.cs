
namespace AnimalHierarchy
{
    using System;
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Sex sex):base(name,age,sex)
        {
        }
        public override string Sound()
        {
            return String.Format("Bau!");
        }
    }
}
