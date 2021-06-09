using System;

namespace MyBanker
{
    public class VisaDK : Card, IUseLimet, ICredit
    {
        public VisaDK(string name, int age) : base(name, age)
        {
        }
        public int SpendLimit()
        {
            throw new NotImplementedException();
        }

        public bool Credit()
        {
            throw new NotImplementedException();
        }
    }
}