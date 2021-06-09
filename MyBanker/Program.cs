using System;

namespace MyBanker
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Card anne = new WithDraw("anne", 22);
            Console.WriteLine(anne.CardNumber);
        }
    }
}