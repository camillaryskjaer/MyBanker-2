using System;

namespace MyBanker
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Card withDraw = new WithDraw("Anne", 12);
            Card maestro = new Maestro("Sigurd", 55);
            Card mastercard = new Mastercard("Frank", 23);
            Card visaDK = new VisaDK("Lis", 52);
            Card visaElectron = new VisaElectron("Jens", 30);
            
            Console.WriteLine("Cardnumber: " + withDraw.CardNumber);
            Console.WriteLine("Accountnumber: " + withDraw.AccountNumber);
        }
    }
}