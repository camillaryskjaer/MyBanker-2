using System;

namespace MyBanker
{
    public class WithDraw : Card, IDebit
    {
        //constructor 
        public WithDraw(string name, int age) : base(name, age)
        {
            Prefix = 2400;
            CreateCardNumber(12);
        }
        
        //implemented (not written) methode from interface
        public bool NoCredit()
        {
            throw new NotImplementedException();
        }
    }
}