﻿
namespace StudentsAndWorkers
{
    using System;
    public abstract class Human
    {
        private string firstName;
        private string lAstName;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
