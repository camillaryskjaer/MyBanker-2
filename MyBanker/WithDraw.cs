using System;

namespace MyBanker
{
    public class WithDraw : Card, INoNigative
    {
        public WithDraw(string name, int age, int accountNumber, int balance, bool internationalUse, DateTime issuedDate, DateTime paymentDay) : base(name, age, accountNumber, balance, internationalUse, issuedDate, paymentDay)
        {
            Prefix = 2400;
            CreateCardNumber(12);
            
            Console.WriteLine(CardNumber);
        }
        
        


        public bool NoCredit()
        {
            throw new NotImplementedException();
        }
    }
}