
namespace BankAccounts
{
    using System;
    public class LoanAccounts : Account, IMoneyOperatable
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

        //Loan accounts have no interest for the first  3  months if are held by individuals and for the first  2  months if are held by a company.
        public override decimal CalculateInterestAmount(int periodOfMonths)
        {
            if (Customer is CompanyCustomer)
            {
                return (periodOfMonths - 3) * InterestRate;
            }
            if (Customer is IndividualCustomer)
            {
                return (periodOfMonths - 2) * InterestRate;
            }
            else
            {
                throw new ArgumentException("Unknown customer!");
            }
        }
        //Constructors
        public LoanAccounts(Customer customer, decimal ballance, decimal interestRate)
            :base(customer,ballance,interestRate)
        {
        }
    }
}
