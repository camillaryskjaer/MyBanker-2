using System;

namespace MyBanker
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Card anne = new WithDraw("anne", 20, 1, 1, false, DateTime.Now, DateTime.Today);
            Console.WriteLine();
        }
    }
}