using System;

namespace MyBanker
{
    public class Card : Account
    {
        private bool internationalUse;
        private DateTime issuedDate;
        private string cardNumber;
        private int ageLimit;
        private DateTime paymentDay;
        private int prefix;

        public int Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        

        public Card(string name, int age, int accountNumber, int balance, bool internationalUse, DateTime issuedDate, DateTime paymentDay) : base(name, age, accountNumber, balance)
        {
            this.internationalUse = internationalUse;
            this.issuedDate = issuedDate;
            
            this.paymentDay = paymentDay;
        }

        public void CreateCardNumber(int length)
        {
            Random random = new Random();
            string cardNumber = Prefix.ToString();

            for (int i = 0; i < length; i++)
            {
                cardNumber += random.Next(0, 9);
            }

            CardNumber = cardNumber;
        }
    }
}