namespace Task2
{
    internal class SavingsAccount :Account
    {
        public SavingsAccount()
        {
        }

        public SavingsAccount(string name,double balance,int rate) : base(name,balance)
        {
            Rate = rate;
        }

        public int Rate { get; set; }

    }
}