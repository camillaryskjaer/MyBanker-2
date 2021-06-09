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
        
        
        
        public Card(string name, int age, int accountNumber, int balance, bool internationalUse, DateTime issuedDate, int cardNumber, int ageLimit, DateTime paymentDay) : base(name, age, accountNumber, balance)
        {
            this.internationalUse = internationalUse;
            this.issuedDate = issuedDate;
            this.cardNumber = cardNumber;
            this.ageLimit = ageLimit;
            this.paymentDay = paymentDay;
        }
    }
}