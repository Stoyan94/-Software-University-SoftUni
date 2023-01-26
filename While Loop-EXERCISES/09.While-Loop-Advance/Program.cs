using System;

namespace _09.While_Loop_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int with = int.Parse(Console.ReadLine());
            int lengt = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int freeSpace = with * lengt * hight;
            string Carton = Console.ReadLine();

            while (Carton != "Done")
            {
                int numCarton = int.Parse(Carton);

                freeSpace -= numCarton;

                if (freeSpace <= 0)
                {
                    break;
                }

                Carton = Console.ReadLine();
            }

            if (freeSpace <= 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
