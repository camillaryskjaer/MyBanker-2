using System;

namespace MyBanker
{
    public class WithDraw : Card, INoNigative
    {
        public WithDraw(string name, int age, int accountNumber, int balance, bool internationalUse, DateTime issuedDate, int cardNumber, int ageLimit, DateTime paymentDay) : base(name, age, accountNumber, balance, internationalUse, issuedDate, cardNumber, ageLimit, paymentDay)
        {
            
        }
        
        public bool NoCredit()
        {
            return true;
        }
        
    }
}