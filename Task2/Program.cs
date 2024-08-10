using System.Security.Principal;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accounts
           var accounts = new List<Account>();
            accounts.Add(new Account( "mahmoud",2000));
            accounts.Add(new Account("Larry",7000));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Display(accounts );
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
        var savAccounts = new List<Account>();
            savAccounts.Add(new SavingsAccount());
            savAccounts.Add(new SavingsAccount("Superman",6000,4));
            savAccounts.Add(new SavingsAccount("Batman", 2000,1));
            savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5));

            AccountUtil.Display(savAccounts);
            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);

            // Checking
            var checAccounts = new List<Account>();
            checAccounts.Add(new CheckingAccount("ahmed",3000,1));
            checAccounts.Add(new CheckingAccount("mo", 1000, 5));
            checAccounts.Add(new CheckingAccount("Moe2", 2000,2.5));
            checAccounts.Add(new CheckingAccount("Curly2", 5000,1.5));

            AccountUtil.Display(checAccounts);
            AccountUtil.Deposit(checAccounts, 1000);
            AccountUtil.Withdraw(checAccounts, 2000);
            AccountUtil.Withdraw(checAccounts, 2000);

            // Trust
            var trustAccounts = new List<Account>();
            trustAccounts.Add(new TrustAccount("ahmed",4000,2 ));
            trustAccounts.Add(new TrustAccount("mohamed",4000,4));
            trustAccounts.Add(new TrustAccount("Batman2", 2000,3));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5));

            AccountUtil.Display(trustAccounts);
            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);

            Console.WriteLine();

        }
    }
}
