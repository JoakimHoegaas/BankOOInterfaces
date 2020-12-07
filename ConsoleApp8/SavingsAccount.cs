using System;
using System.Collections.Generic;

namespace BankOOInterfaces
{
    public class SavingsAccount : ISavingsAccount
    {
        public string AccountType { get; set; } = "sparekonto";
        public Customer Customer { get; set; }
        public List<Transaction> Transactions { get; set; }
        public int Balance { get; set; }
        public int SavingsAccountsLeft { get; set; } = 5;

        public SavingsAccount(Customer customer)
        {
            if(SavingsAccountsLeft < 1) Console.WriteLine("Slutt! Du får bare fem!");
            SavingsAccountsLeft--;
        }

        public void PrintAccountText(Customer customer)
        {
            Console.WriteLine($"Gratulerer {customer.Name}! Du har nå opprettet en {AccountType} hos oss");
        }

        public void Deposit(int sum)
        {

        }
    }
}
