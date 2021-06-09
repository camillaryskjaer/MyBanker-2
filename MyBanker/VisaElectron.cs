using System;

namespace MyBanker
{
    public class VisaElectron : Card, IUseLimet
    {
        
        
        public int SpendLimit()
        {
            throw new NotImplementedException();
        }

        public VisaElectron(string name, int age, int accountNumber, int balance, bool internationalUse, DateTime issuedDate, DateTime paymentDay) : base(name, age, accountNumber, balance, internationalUse, issuedDate, paymentDay)
        {
        }
    }
}