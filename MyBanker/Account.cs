namespace MyBanker
{
    public class Account : User
    {
        private int accountNumber;
        private int balance;
        public Account(string name, int age, int accountNumber, int balance) : base(name, age)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
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