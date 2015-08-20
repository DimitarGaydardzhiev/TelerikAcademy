namespace People
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Person ConfigurePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "Ivan";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Jenifer";
                newPerson.Gender = Gender.Female;
            }

            return newPerson;
        }
    }
}
