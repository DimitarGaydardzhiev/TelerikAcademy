
namespace AnimalHierarchy
{
    using System;
    public class Cat : Animal, ISound
    {
        
        public override string Sound()
        {
            return String.Format("Miau!");
        }
        public Cat(string name, int age, Sex sex) : base(name,age,sex)
        {
        }

    }
}
