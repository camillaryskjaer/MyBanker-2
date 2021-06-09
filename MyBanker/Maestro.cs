using System;

namespace MyBanker
{
    public class Maestro : Card, INoNigative
    {
        public Maestro(string name, int age, int accountNumber, int balance, bool internationalUse, DateTime issuedDate, DateTime paymentDay) : base(name, age, accountNumber, balance, internationalUse, issuedDate, paymentDay)
        {
        }

        public bool NoCredit()
        {
            throw new NotImplementedException();
        }
    }
}