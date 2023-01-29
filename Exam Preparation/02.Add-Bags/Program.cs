using System;

namespace _02.Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceLagguage = double.Parse(Console.ReadLine());
            double kiloLagguage = double.Parse(Console.ReadLine());
            int daysToTravel = int.Parse(Console.ReadLine());
            int numLagguage = int.Parse(Console.ReadLine());

            double priceKilo = 0;

            if (kiloLagguage <= 10)
            {
                priceKilo = priceLagguage * 0.20;
            }
            else if (kiloLagguage <= 20)
            {
                priceKilo = priceLagguage * 0.50;
            }
            else
            {
                priceKilo = priceLagguage;
            }

            if (daysToTravel < 7)
            {
                priceKilo *= 1.40;
            }
            else if (daysToTravel >= 7 && daysToTravel <= 30)
            {
                priceKilo *= 1.15;
            }
            else if (daysToTravel > 30)
            {
                priceKilo *= 1.10;
            }

            double finalSum = priceKilo * numLagguage;

            Console.WriteLine($"The total price of bags is: {finalSum:F2} lv.");
        }
    }
}
