using System;

namespace _03.Nested_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double expences = double.Parse(Console.ReadLine());

                double saving = 0;

                while (expences > saving)
                {
                    saving += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
