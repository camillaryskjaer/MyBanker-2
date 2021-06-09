using System;

namespace MyBanker
{
    public class Mastercard : Card, ICredit, IUseLimet
    {
        public Mastercard(string name, int age) : base(name, age)
        {
        
        }
        public bool Credit()
        {
            throw new NotImplementedException();
        }
        public int SpendLimit()
        {
            throw new NotImplementedException();
        }
    }
}