using System.Collections.Generic;

namespace BankOOInterfaces
{
    public interface IAccount
     {
         string AccountType { get; set; }
         Customer Customer { get; set; }
         List<Transaction> Transactions { get; set; } 
         int Balance { get; set; }

        void Deposit(int sum);
        void PrintAccountText(Customer customer);


    }
}
