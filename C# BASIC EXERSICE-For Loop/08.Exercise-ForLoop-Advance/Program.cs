using System;

namespace _08.Exercise_ForLoop_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tourCount = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int pointsWon = 0;
            int torWon = 0;

            for (int i = 0; i < tourCount; i++)
            {
                string typeTor = Console.ReadLine();

                if (typeTor == "W")
                {
                    pointsWon += 2000;
                    torWon++;
                }
                else if (typeTor == "F")
                {
                    pointsWon += 1200;
                }
                else if (typeTor == "SF")
                {
                    pointsWon += 720;
                }
            }
            Console.WriteLine($"Final points: {startPoints + pointsWon}");
            int averagePoits = pointsWon / tourCount;
            Console.WriteLine($"Average points: {averagePoits}");
            double preTour = (double)torWon / tourCount * 100;
            Console.WriteLine($"{preTour:F2}%");
        }
    }
}
