using System;

namespace _06.Exercise_ForLoop_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearLili = int.Parse(Console.ReadLine());
            double priceWasher = double.Parse(Console.ReadLine());
            int toysCount = int.Parse(Console.ReadLine());

            double evenBird = 0;
            double toysPrice = 0;

            double totalEven = 0;

            for (int i = 1; i <= yearLili; i++)
            {

                if (i % 2 == 0)
                {
                    evenBird += 10;
                    totalEven = (totalEven + evenBird) - 1;
                }
                else
                {
                    toysPrice += toysCount;
                }

            }

            double totalPrice = totalEven + toysPrice;

            if (totalPrice >= priceWasher)
            {
                Console.WriteLine($"Yes! {totalPrice - priceWasher:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWasher - totalPrice:F2}");
            }
        }
    }
}
