using System;

namespace MyBanker
{
    public class Account : User
    {
        private string accountNumber;
        private int balance;
        private int reg;
        public Account(string name, int age) : base(name, age)
        {
            Reg = 3520;
            CreateAccountNumber(10);
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public int Reg
        {
            get { return reg; }
            set { reg = value; }
        }
        
        public void CreateAccountNumber(int length)
        {
            Random random = new Random();
            string accountNumber = reg.ToString();

            for (int i = 0; i < length; i++)
            {
                accountNumber += random.Next(0, 9);
            }

            AccountNumber = accountNumber;
        }
    }
}