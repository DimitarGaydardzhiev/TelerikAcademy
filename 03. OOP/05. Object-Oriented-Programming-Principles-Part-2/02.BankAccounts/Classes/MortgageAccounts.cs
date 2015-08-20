
namespace BankAccounts
{
    using System;
    public class MortgageAccounts : Account, IMoneyOperatable
    {
        //Methods
        public decimal Deposit(decimal sum)
        {
            if (sum < 0)
            {
                throw new ArgumentException("You can't deposit negative amount of money!");
            }
            else
            {
                return Ballance += sum;
            }
        }

        public decimal Withdraw(decimal sum)
        {
            throw new NotSupportedException("You are not allowed to withdraw money from this account!");
        }

        public override decimal CalculateInterestAmount(int periodOfMonths)
        {
            if (Customer is CompanyCustomer)
            {
                return (periodOfMonths - 12) * InterestRate + 12 / 2 * InterestRate;
            }
            if (Customer is IndividualCustomer)
            {
                return (periodOfMonths - 6) * InterestRate;
            }
            else
            {
                throw new ArgumentException("Unknown customer!");
            }
        }

        //Constructors
        public MortgageAccounts(Customer customer, decimal ballance, decimal interestRate)
            :base(customer,ballance,interestRate)
        {
        }
    }
}
