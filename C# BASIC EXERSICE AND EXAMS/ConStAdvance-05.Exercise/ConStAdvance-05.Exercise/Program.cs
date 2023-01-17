using System;

namespace NewSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int bugetGroop = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            const double spring = 3000;
            const double summer = 4200;
            const double autumn = 4200;
            const double winter = 2600;
            double total = 0;

            switch (season)
            {
                case "Spring":
                    if (fishers <= 6)
                    {
                        total = spring * 0.9;

                    }
                    else if (fishers >= 7 && fishers <= 11)
                    {
                        total = spring * 0.85;
                    }
                    else
                    {
                        total = spring * 0.75;
                    }
                    if (fishers % 2 == 0)
                    {
                        total = total * 0.95;
                    }
                    break;
                case "Summer":
                    if (fishers <= 6)
                    {
                        total = summer * 0.9;

                    }
                    else if (fishers >= 7 && fishers <= 11)
                    {
                        total = summer * 0.85;
                    }
                    else
                    {
                        total = summer * 0.75;
                    }
                    if (fishers % 2 == 0)
                    {
                        total = total * 0.95;
                    }
                    break;
                case "Autumn":
                    if (fishers <= 6)
                    {
                        total = autumn * 0.9;

                    }
                    else if (fishers >= 7 && fishers <= 11)
                    {
                        total = autumn * 0.85;
                    }
                    else
                    {
                        total = autumn * 0.75;
                    }
                    break;
                case "Winter":
                    if (fishers <= 6)
                    {
                        total = winter * 0.9;

                    }
                    else if (fishers >= 7 && fishers <= 11)
                    {
                        total = winter * 0.85;
                    }
                    else
                    {
                        total = winter * 0.75;
                    }
                    if (fishers % 2 == 0)
                    {
                        total = total * 0.95;
                    }
                    break;

            }
            if (bugetGroop >= total)
            {
                Console.WriteLine($"Yes! You have {bugetGroop - total:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {total - bugetGroop:F2} leva.");
            }


        }


    }
}

