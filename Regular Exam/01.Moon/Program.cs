using System;

namespace _01.Moon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speedKm = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            double distance = 384400;

            double fullTime = distance * 2;
            double timeBack = Math.Ceiling(fullTime / speedKm);
            double sumTime = timeBack + 3;
            double sumFuel = (fuel * fullTime) / 100;

            Console.WriteLine($"{Math.Ceiling(sumTime)}");
            Console.WriteLine(sumFuel);

        }
    }
}
