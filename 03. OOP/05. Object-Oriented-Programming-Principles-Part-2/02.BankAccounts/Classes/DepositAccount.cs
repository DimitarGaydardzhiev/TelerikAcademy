
namespace BankAccounts
{
    using System;
    public class DepositAccount : Account, IMoneyOperatable
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
            if (sum>Ballance)
            {
                throw new ArgumentException("You do not have enought ballance in your account!");
            }
            else
            {
                return Ballance -= sum;
            }
        }

        public override decimal CalculateInterestAmount(int periodOfMonths)
        {
            if (Ballance > 0 && Ballance < 1000m)
            {
                return 0m;
            }
            else
            {
                return periodOfMonths * InterestRate;
            }
        }

        //Constructors
        public DepositAccount(Customer customer, decimal ballance, decimal interestRate)
            :base(customer,ballance,interestRate)
        {
        }
    }
}
