using System;
using System.Collections.Generic;

namespace BankOOInterfaces
{
    public class Bank
    {
        public List<Customer> CustomerList;
        public List<IAccount> AccountList;

        public Bank()
        {
            CustomerList = new List<Customer>();
            AccountList = new List<IAccount>();
        }

        public Customer CreateCustomer(string name)
        {
            return new Customer(name);
        }

        public DebitAccount CreateDebitAccount(Customer customer)
        {
            var debitAccount = new DebitAccount(customer);
            AccountList.Add(debitAccount);
            return new DebitAccount(customer);
        }

        public SavingsAccount CreateSavingsAccount(Customer customer)
        {
            var savingsAccount = new SavingsAccount(customer);
            AccountList.Add(savingsAccount);
            return new SavingsAccount(customer);
        }

        public void GetAccountsText(Customer customer)
        {
            foreach (var account in AccountList)
            {
                account.PrintAccountText(customer);
                if (account is ISavingsAccount savingsAccount)
                {
                    Console.WriteLine($"Du kan nå opprette {savingsAccount.SavingsAccountsLeft} flere sparekontoer");
                }
            }
        }
    }
}
