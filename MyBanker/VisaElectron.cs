using System;

namespace MyBanker
{
    public class VisaElectron : Card, IUseLimet
    {
        public VisaElectron(string name, int age) : base(name, age)
        {
            
        }
        public int SpendLimit()
        {
            throw new NotImplementedException();
        }

        
    }
}