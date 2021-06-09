using System;

namespace MyBanker
{
    public class VisaElectron : Card, IUseLimet
    {
        public VisaElectron(string name, int age) : base(name, age)
        {
            
        }
        
        //implementet (not written) methode from the interface: IUseLimit
        public int SpendLimit()
        {
            throw new NotImplementedException();
        }
    }
}