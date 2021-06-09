using System;

namespace MyBanker
{
    public class VisaDK : Card, IUseLimet, ICredit
    {
        public VisaDK(string name, int age, int accountNumber, int balance, bool internationalUse, DateTime issuedDate, int cardNumber, int ageLimit, DateTime paymentDay) : base(name, age, accountNumber, balance, internationalUse, issuedDate, cardNumber, ageLimit, paymentDay)
        {
        
        }

        public int SpendLimit()
        {
            throw new NotImplementedException();
        }

        public bool Credit()
        {
            throw new NotImplementedException();
        }
    }
}