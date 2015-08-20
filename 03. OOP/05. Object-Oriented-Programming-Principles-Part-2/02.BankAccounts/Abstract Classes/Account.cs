
namespace BankAccounts
{
    using System;
    public abstract class Account
    {
        //Fields
        private Customer customer;
        private decimal ballance;
        private decimal interestRate;


        //Properties
        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Ballance
        {
            get
            {
                return this.ballance;
            }
            set
            {
                this.ballance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        //Methods

        public virtual decimal CalculateInterestAmount (int periodOfMonths)
        {
            return periodOfMonths * InterestRate;
        }

        //Constructor
        public Account(Customer customer, decimal ballance, decimal interestRate)
        {
            this.Customer = customer;
            this.Ballance = ballance;
            this.InterestRate = interestRate;
        }
    }
}
