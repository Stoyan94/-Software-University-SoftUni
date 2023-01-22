using System;

namespace _01.While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalMoney = 0;
            while (input != "NoMoreMoney")
            {
                double transaction = double.Parse(input);
                if (transaction <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {transaction:F2}");
                totalMoney += transaction;


                input = Console.ReadLine();

            }
            Console.WriteLine($"Total: {totalMoney:F2}");
        }
    }
}
