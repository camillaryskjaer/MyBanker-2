using System;

namespace MyBanker
{
    public class WithDraw : Card, IDebit
    {
        public WithDraw(string name, int age) : base(name, age)
        {
            Prefix = 2400;
            CreateCardNumber(12);
        }
        public bool NoCredit()
        {
            throw new NotImplementedException();
        }
    }
}