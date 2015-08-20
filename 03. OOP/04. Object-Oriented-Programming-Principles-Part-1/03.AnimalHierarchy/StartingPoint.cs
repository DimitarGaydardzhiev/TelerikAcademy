/*
Problem 3. Animal hierarchy
• Create a hierarchy  Dog ,  Frog ,  Cat ,  Kitten ,  Tomcat  and define useful constructors and methods. 
Dogs, frogs and cats are  Animals . All animals can produce sound (specified by the  ISound  interface). 
Kittens and tomcats are cats. All animals are described by age, name and sex. 
Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
• Create arrays of different kinds of animals 
and calculate the average age of each kind of animal using a static method (you may use LINQ).
*/

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartingPoint
    {
        
        public static void Main()
        {
            Cat[] cats = new Cat[]
            {
                new Cat("Jonny", 1, Sex.male),
                new Cat("Hue", 2, Sex.male),
                new Cat("Maia", 2, Sex.female),
            };

            Dog[] dogs = new Dog[]
            {
                new Dog("Ivo", 5, Sex.male),
                new Dog("Pesho", 4, Sex.male),
                new Dog("Maria", 8, Sex.female),
            };

            Frog[] frogs = new Frog[]
            {
                new Frog("Gosho", 4, Sex.male),
                new Frog("Ivan", 5, Sex.female),
                new Frog("Zahari", 3, Sex.male)
            };

            Kitten[] kittens = new Kitten[]
            {
                new Kitten("Mihaela", 5),
                new Kitten("Ivona", 3),
                new Kitten("Petra", 2)
            };

            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat("Rado", 3),
                new Tomcat("Radoi", 3),
                new Tomcat("Frodo", 2)
            };

            Console.WriteLine("Cats average age is: ");
            Console.WriteLine("{0:F2}", Cat.AverageAge(cats));
            Console.WriteLine("The cat say: {0}", cats[0].Sound());
            Console.WriteLine();

            Console.WriteLine("Cats average age is: ");
            Console.WriteLine("{0:F2}", Dog.AverageAge(dogs));
            Console.WriteLine("The cat say: {0}", dogs[0].Sound());
            Console.WriteLine();

            Console.WriteLine("Cats average age is: ");
            Console.WriteLine("{0:F2}", Frog.AverageAge(frogs));
            Console.WriteLine("The cat say: {0}", frogs[0].Sound());
            Console.WriteLine();

            Console.WriteLine("Cats average age is: ");
            Console.WriteLine("{0:F2}", Kitten.AverageAge(kittens));
            Console.WriteLine("The cat say: {0}", kittens[0].Sound());
            Console.WriteLine();

            Console.WriteLine("Cats average age is: ");
            Console.WriteLine("{0:F2}", Tomcat.AverageAge(tomcats));
            Console.WriteLine("The cat say: {0}", tomcats[0].Sound());
        }
    }
}
