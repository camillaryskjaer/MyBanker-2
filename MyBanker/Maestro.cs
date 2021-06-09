using System;

namespace MyBanker
{
    //Subclass to the superclass: Card, and the interface: Idebet
    public class Maestro : Card, IDebit
    {
        //Constructor
        public Maestro(string name, int age) : base(name, age)
        {
            
        }
        
        //implementet (not written) methode from the interface: IDebit
        public bool NoCredit()
        {
            throw new NotImplementedException();
        }
    }
}