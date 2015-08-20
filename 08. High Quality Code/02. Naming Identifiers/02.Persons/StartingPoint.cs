namespace People
{
    using System;

    public class StartingPoint
    {
        public static void Main()
        {
            var newMan = new Person();
            newMan = newMan.ConfigurePerson(14);
            Console.WriteLine(newMan.Gender);

            var newWomen = new Person();
            newWomen = newWomen.ConfigurePerson(17);
            Console.WriteLine(newWomen.Gender);
        }
    }
}
