namespace MyBanker
{
    public class Account : User
    {
        private int accountNumber;
        private int balance;
        public Account(string name, int age) : base(name, age)
        {
            
        }
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}