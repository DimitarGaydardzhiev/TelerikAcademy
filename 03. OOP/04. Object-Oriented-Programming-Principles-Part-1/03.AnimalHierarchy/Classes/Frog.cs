
namespace AnimalHierarchy
{
    using System;
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Sex sex):base(name,age,sex)
        {
        }

        public override string Sound()
        {
            return String.Format("Kvak!");
        }

    }
}
