using System;

namespace _05.While_Loop_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeed = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            int totalDays = 0;
            int spendDays = 0;

            while (moneyAvailable < moneyNeed)
            {
                string moneyAction = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                totalDays++;
                if (moneyAction == "save")
                {
                    moneyAvailable += amount;
                    if (moneyAvailable >= moneyNeed)
                    {
                        Console.WriteLine($"You saved the money for {totalDays} days.");
                        break;
                    }
                    spendDays = 0;
                }
                else if (moneyAction == "spend")
                {
                    spendDays++;
                    if (spendDays >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(totalDays);
                        break;
                    }
                    moneyAvailable -= amount;
                    if (moneyAvailable < 0)
                    {
                        moneyAvailable = 0;
                    }
                }
            }
        }
    }
}
