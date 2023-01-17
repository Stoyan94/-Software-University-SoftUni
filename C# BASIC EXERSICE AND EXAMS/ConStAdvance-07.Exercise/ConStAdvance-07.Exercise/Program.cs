using System;

namespace NewSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "";
            string buildings = "";
            double price = 0;

            if (budget <= 100)
            {
                place = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        price = budget * 0.3;
                        buildings = "Camp";
                        break;
                    case "winter":
                        price = budget * 0.7;
                        buildings = "Hotel";
                        break;
                }
            }
            else if (budget <= 1000)
            {
                place = "Balkans";
                switch (season)
                {
                    case "summer":
                        price = budget * 0.4;
                        buildings = "Camp";
                        break;
                    case "winter":
                        price = budget * 0.8;
                        buildings = "Hotel";
                        break;
                }
            }
            else if (budget > 1000)
            {
                place = "Europe";
                price = budget * 0.9;
                buildings = "Hotel";
            }
            Console.WriteLine($"Somewhere in {place} ");
            Console.WriteLine($"{buildings} - {price:F2}");
        }
    }
}

