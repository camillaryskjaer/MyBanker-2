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
            CreateAccountNumber();
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
        
        //Creating a new account number
        public void CreateAccountNumber()
        {
            //making a random function
            Random random = new Random();
            
            //initialising that account number contains my prefixed registation number
            string accountNumber = reg.ToString();

            //adding a randome number to the account number as long the account number is shorter than 10
            for (int i = 0; i < 10; i++)
            {
                accountNumber += random.Next(0, 9);
            }

            AccountNumber = accountNumber;
        }
    }
}