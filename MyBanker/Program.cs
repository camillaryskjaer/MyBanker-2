using System;

namespace MyBanker
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //creating an object of the five different cards MyBanker offers for 5 different costumers
            Card withDraw = new WithDraw("Anne", 12);
            Card maestro = new Maestro("Sigurd", 55);
            Card mastercard = new Mastercard("Frank", 23);
            Card visaDk = new VisaDK("Lis", 52);
            Card visaElectron = new VisaElectron("Jens", 30);
            
            //Confirming that my objects works an that they are able of creating both accountnumbers and cardnumbers
            Console.WriteLine("Cardnumber withDraw: " + withDraw.CardNumber);
            Console.WriteLine("Accountnumber withDraw: " + withDraw.AccountNumber);
            
            Console.WriteLine("Cardnumber visaDk: " + visaDk.CardNumber);
            Console.WriteLine("Accountnumber visaDk: " + visaDk.AccountNumber);
        }
    }
}