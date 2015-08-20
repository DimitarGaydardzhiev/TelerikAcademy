
namespace AnimalHierarchy
{
    using System;
    public class Tomcat : Cat, ISound
    {
        protected const string sex = "male";
        public override string Sound()
        {
            return String.Format("Mrrr, I am Tomcat!");
        }
        public Tomcat(string name, int age)
            : base(name,age,Sex.male)
        {

        }
    }
}
