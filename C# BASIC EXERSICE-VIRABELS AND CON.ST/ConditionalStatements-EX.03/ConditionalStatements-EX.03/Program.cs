using System;

namespace ShopComp
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoKart = int.Parse(Console.ReadLine());
            int procesor = int.Parse(Console.ReadLine());
            int RAW = int.Parse(Console.ReadLine());

            double priceVideo = videoKart * 250;
            double priceProcesor = procesor * (priceVideo * 0.35);
            double priceRaw = RAW * (priceVideo * 0.1);
            double total = priceVideo + priceProcesor + priceRaw;

            if (videoKart > procesor)
            {
                total = total - (total * 0.15);
            }


            if (total <= budget)
            {

                double result = budget - total;
                Console.WriteLine($"You have {result:F2} leva left!");
            }

            else if (total > budget)
            {
                double result = Math.Abs(budget - total);
                Console.WriteLine($"Not enough money! You need {result:F2} leva more!");
            }
        }
    }
}
