using System;

namespace ShopComp
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            double epsiode = double.Parse(Console.ReadLine());
            double breakT = double.Parse(Console.ReadLine());
            double totalTime = epsiode;
            totalTime += breakT / 8;
            totalTime += breakT / 4;
            if (breakT >= totalTime)
            {
                double leftime = Math.Ceiling(breakT - totalTime);
                Console.WriteLine($"You have enough time to watch {serial} and left with {leftime} minutes free time.");
            }
            else
            {
                double leftime = Math.Ceiling(totalTime - breakT);
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {leftime} more minutes.");
            }

        }
    }
}
