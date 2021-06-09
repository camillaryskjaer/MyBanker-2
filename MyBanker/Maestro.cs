using System;

namespace MyBanker
{
    public class Maestro : Card, IDebit
    {
        public Maestro(string name, int age) : base(name, age)
        {
            
        }
        public bool NoCredit()
        {
            throw new NotImplementedException();
        }
    }
}