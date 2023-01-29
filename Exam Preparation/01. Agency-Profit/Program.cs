using System;

namespace _01._Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameCompany = Console.ReadLine();

            int ticketAdult = int.Parse(Console.ReadLine());
            int ticketKids = int.Parse(Console.ReadLine());

            double priceAdult = double.Parse(Console.ReadLine());
            double priceService = double.Parse(Console.ReadLine());

            double priceTicketKid = priceAdult * 0.30;
            double addSerAd = priceAdult + priceService;
            double addSerKid = priceTicketKid + priceService;

            double total = 0;

            total = ticketAdult * addSerAd;
            total += ticketKids * addSerKid;
            total *= 0.20;

            Console.WriteLine($"The profit of your agency from {nameCompany} tickets is {total:F2} lv.");
        }
    }
}
