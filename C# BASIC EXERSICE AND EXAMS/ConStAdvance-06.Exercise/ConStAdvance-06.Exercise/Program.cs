using System;

namespace NewSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double total = 0;
            const double roses = 5;
            const double dahlias = 3.80;
            const double tulips = 2.80;
            const double narcissus = 3;
            const double gladiolus = 2.50;

            switch (flowerType)
            {
                case "Roses":
                    total = flowersCount * roses;
                    if (flowersCount > 80)
                    {
                        total = flowersCount * roses * 0.9;
                    }
                    break;
                case "Dahlias":
                    total = flowersCount * dahlias;
                    if (flowersCount > 90)
                    {
                        total = flowersCount * dahlias * 0.85;
                    }
                    break;
                case "Tulips":
                    total = flowersCount * tulips;
                    if (flowersCount > 80)
                    {
                        total = flowersCount * tulips * 0.85;
                    }
                    break;
                case "Narcissus":
                    total = flowersCount * narcissus;
                    if (flowersCount < 120)
                    {
                        total = flowersCount * narcissus * 1.15;
                    }
                    break;
                case "Gladiolus":
                    total = flowersCount * gladiolus;
                    if (flowersCount < 80)
                    {
                        total = flowersCount * gladiolus * 1.20;
                    }
                    break;
            }
            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {budget - total:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total - budget:F2} leva more.");
            }


        }


    }
}

