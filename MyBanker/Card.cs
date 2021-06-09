using System;

namespace MyBanker
{
    public class Card : Account
    {
        private bool internationalUse;
        private DateTime issuedDate;
        private int cardNumber;
        private int ageLimit;
        private DateTime paymentDay;
        private int prefix;

        public int Prefix { get { return prefix; } set { prefix = value; } }

        public Card(string name, int age, int accountNumber, int balance, bool internationalUse, DateTime issuedDate, int cardNumber, int ageLimit, DateTime paymentDay) : base(name, age, accountNumber, balance)
        {
            this.internationalUse = internationalUse;
            this.issuedDate = issuedDate;
            this.cardNumber = cardNumber;
            this.ageLimit = ageLimit;
            this.paymentDay = paymentDay;
        }

        public void CreateCardNumber(int length)
        {
            Random random = new Random();
            string cardNumber = Prefix.ToString();
            
        }
    }
}