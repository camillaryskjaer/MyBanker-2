using System;

namespace MyBanker
{
    //Subclass to the superclass: Card, and the interface: Idebet
    public class Maestro : Card, IDebit
    {
    
    //Du får ikke rigtigt gjort brug af superklassen til at håndtere disse prefixes og det burde den gøre
        private int[] preFixArray = {5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763};
        private Random random = new Random();
        //Constructor
        public Maestro(string name, int age) : base(name, age)
        {
            int container = random.Next(preFixArray.Length);
            Prefix = preFixArray[container];
            //Console.WriteLine("test " + Prefix);

            CreateCardNumber(15);
        }
        
        //implementet (not written) methode from the interface: IDebit
        public bool NoCredit()
        {
        //Hmm
            throw new NotImplementedException();
        }
    }
}
