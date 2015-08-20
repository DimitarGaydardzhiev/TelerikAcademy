
namespace BankAccounts
{
    public interface IMoneyOperatable
    {
        decimal Deposit(decimal sum);
        decimal Withdraw(decimal sum);
    }
}
