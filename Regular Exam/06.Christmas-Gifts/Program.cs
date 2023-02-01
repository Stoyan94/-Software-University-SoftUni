using System;

namespace _05.Christmas_Gifts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string holyday = Console.ReadLine();

            int kids = 0;
            int adults = 0;

            const int kidPresents = 5;
            const int adultPresents = 15;

            int sumKidPr = 0;
            int sumAdulsPr = 0;

            while (holyday != "Christmas")
            {
                int age = int.Parse(holyday);
                if (age <= 16)
                {
                    kids++;
                    sumKidPr += kidPresents;
                }
                else if (age > 16)
                {
                    adults++;
                    sumAdulsPr += adultPresents;
                }
                holyday = Console.ReadLine();
            }

            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {sumKidPr}");
            Console.WriteLine($"Money for sweaters: {sumAdulsPr}");

        }
    }
}
