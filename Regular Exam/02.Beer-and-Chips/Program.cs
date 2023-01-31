using System;

namespace _02.Beer_and_Chips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beears = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());

            double buyBeears = beears * 1.20;
            double buyChips = buyBeears * 0.45;

            double totalChips = Math.Ceiling(buyChips * chips);
            double totalSum = buyBeears + totalChips;

            if (totalSum <= budget)
            {
                Console.WriteLine($"{name} bought a snack and has {budget - totalSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {totalSum - budget:F2} more leva!");
            }

        }
    }
}
