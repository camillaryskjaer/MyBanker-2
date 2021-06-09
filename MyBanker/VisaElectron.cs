using System;

namespace MyBanker
{
    public class VisaElectron : Card, IUseLimet
    {
        public VisaElectron(string name, int age, int accountNumber, int balance, bool internationalUse, DateTime issuedDate, int cardNumber, int ageLimit, DateTime paymentDay) : base(name, age, accountNumber, balance, internationalUse, issuedDate, cardNumber, ageLimit, paymentDay)
        {
        
        }
        
        public int SpendLimit()
        {
            throw new NotImplementedException();
        }
    }
}