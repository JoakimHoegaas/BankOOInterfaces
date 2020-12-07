namespace BankOOInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            var customer = bank.CreateCustomer("Terje");
            bank.CreateDebitAccount(customer);
            bank.CreateSavingsAccount(customer);
            bank.GetAccountsText(customer);
            //debitAccount.Deposit(1000);
            //Bank.Transfer(customer, savingsAccount, debitAccount, 200);
            //Console.WriteLine(debitAccount.Balance);
            //Console.WriteLine(savingsAccount.Balance);
        }
    }
}
