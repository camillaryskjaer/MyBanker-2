using System;

namespace MyBanker
{
    public class VisaElectron : Card, IUseLimet
    {
        private int[] preFixArray = {4026, 417500, 4508, 4844, 4913, 4917};
        private Random random = new Random();
        public VisaElectron(string name, int age) : base(name, age)
        {
            int container = random.Next(preFixArray.Length);
            Prefix = preFixArray[container];
            Console.WriteLine("test " + Prefix);

            if (Prefix < 417500)
            {
                CreateCardNumber(12);
            }
            else
            {
                CreateCardNumber(9);
            }
            
        }
        
        //implementet (not written) methode from the interface: IUseLimit
        public int SpendLimit()
        {
            throw new NotImplementedException();
        }
    }
}