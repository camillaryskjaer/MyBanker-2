using System;

namespace MyBanker
{
    public class VisaDK : Card, IUseLimet, ICredit
    {
        //constructor
        public VisaDK(string name, int age) : base(name, age)
        {
            Prefix = 4;
            CreateCardNumber(15);
        }
        
        //implementet (not written) methode from the interface: IUseLimit
        public int SpendLimit()
        {
            throw new NotImplementedException();
        }
        
        //implementet (not written) methode from the interface: ICredit
        public bool Credit()
        {
            throw new NotImplementedException();
        }
    }
}