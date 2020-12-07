namespace BankOOInterfaces
{
    public interface ISavingsAccount : IAccount
    {
        int SavingsAccountsLeft { get; set; }
    }
}
