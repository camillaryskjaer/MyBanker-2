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

        public bool InternationalUse
        {
            get { return internationalUse; }
            set { internationalUse = value; }
        }

        public DateTime IssuedDate
        {
            get { return issuedDate; }
            set { issuedDate = value; }
        }
        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        public int AgeLimit
        {
            get { return ageLimit; }
            set { ageLimit = value; }
        }
        public DateTime PaymentDay
        {
            get { return paymentDay; }
            set { paymentDay = value; }
        }
        public int Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }
        public Card(string name, int age) : base(name, age)
        {
            
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