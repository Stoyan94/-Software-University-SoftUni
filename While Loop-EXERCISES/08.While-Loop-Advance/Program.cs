using System;

namespace _08.While_Loop_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakceSize = width * lenght;

            string pieces = Console.ReadLine();

            while (pieces != "STOP")
            {
                int takePieces = int.Parse(pieces);


                cakceSize -= takePieces;

                if (cakceSize <= 0)
                {
                    break;
                }

                pieces = Console.ReadLine();
            }

            if (cakceSize <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakceSize)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{cakceSize} pieces are left.");
            };
        }
    }
}
