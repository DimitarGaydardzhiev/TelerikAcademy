﻿
namespace BankAccounts
{
    using System;
    public abstract class Customer
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public Customer(string name)
        {
            this.name = name;
        }
    }
}
