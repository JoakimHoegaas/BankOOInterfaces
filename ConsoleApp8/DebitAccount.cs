using System;
using System.Collections.Generic;

namespace BankOOInterfaces
{
    public class DebitAccount : IAccount
    {
        public string AccountType { get; set; } = "brukskonto";
        public Customer Customer { get; set; }
        public List<Transaction> Transactions { get; set; }
        public int Balance { get; set; }

        public DebitAccount(Customer customer)
        {

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
