using System;

namespace MyBanker
{
    public class VisaDK : Card, IUseLimet, ICredit
    {
       

        public int SpendLimit()
        {
            throw new NotImplementedException();
        }

        public bool Credit()
        {
            throw new NotImplementedException();
        }

        public VisaDK(string name, int age, int accountNumber, int balance, bool internationalUse, DateTime issuedDate, DateTime paymentDay) : base(name, age, accountNumber, balance, internationalUse, issuedDate, paymentDay)
        {
        }
    }
}