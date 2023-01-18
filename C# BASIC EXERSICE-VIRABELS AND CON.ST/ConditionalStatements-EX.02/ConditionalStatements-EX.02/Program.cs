using System;

namespace demo_15_min
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSec = double.Parse(Console.ReadLine());
            double rastoqnieMetri = double.Parse(Console.ReadLine());
            double raztoqnie1MetSec = double.Parse(Console.ReadLine());
            double newRecord = rastoqnieMetri * raztoqnie1MetSec;
            double zabavqne = Math.Floor(rastoqnieMetri / 15) * 12.5;
            double total = newRecord + zabavqne;

            if (recordSec <= total)
            {
                double result = total - recordSec;
                Console.WriteLine($"No, he failed! He was {result:F2} seconds slower.");
            }
            else if (recordSec > total)
            {

                Console.WriteLine($" Yes, he succeeded! The new world record is {total:F2} seconds.");
            }




        }
    }
}
