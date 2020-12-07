namespace BankOOInterfaces
{
    public class Customer
    {
        public string Name;
        //public List<Account> Accounts;
        //public Account DefaultAccount;

        public Customer(string name)
        {
            Name = name;
            //IdGenerator++;
            //DefaultAccount = new Account(Name,"Brukerkonto1");
            //Accounts = new List<Account>(); // {DefaultAccount};

        }
    }
}
