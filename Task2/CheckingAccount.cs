namespace Task2
{
    internal class CheckingAccount :Account
    {
      

        public CheckingAccount(string name, double balance,double fee):base(name,balance)
        {
            Fee = fee;
        }

        public  double Fee { get; set; }
    }
}