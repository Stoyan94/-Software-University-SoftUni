using System;

namespace _03._Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numJoinery = int.Parse(Console.ReadLine());
            string typeJoi = Console.ReadLine();
            string typeDel = Console.ReadLine();

            double priceJoi = 0;
            double priceSum = 0;

            switch (typeJoi)
            {
                case "90X130":
                    priceJoi = 110;

                    if (numJoinery > 30 && numJoinery <= 60)
                    {
                        priceSum = numJoinery * priceJoi;
                        priceSum *= 0.95;
                    }
                    else if (numJoinery > 60)
                    {
                        priceSum = numJoinery * priceJoi;
                        priceSum *= 0.92;
                    }
                    break;

                case "100X150":

                    priceJoi = 140;
                    if (numJoinery > 40 && numJoinery <= 80)
                    {
                        priceSum = numJoinery * priceJoi;
                        priceSum *= 0.94;
                    }
                    else if (numJoinery > 80)
                    {
                        priceSum = numJoinery * priceJoi;
                        priceSum *= 0.90;
                    }
                    break;

                case "130X180":

                    priceJoi = 190;
                    if (numJoinery > 20 && numJoinery <= 50)
                    {
                        priceSum = numJoinery * priceJoi;
                        priceSum *= 0.93;
                    }
                    else if (numJoinery > 50)
                    {
                        priceSum = numJoinery * priceJoi;
                        priceSum *= 0.88;
                    }
                    break;

                case "200X300":

                    priceJoi = 250;
                    if (numJoinery > 25 && numJoinery <= 50)
                    {
                        priceSum = numJoinery * priceJoi;
                        priceSum *= 0.91;
                    }
                    else if (numJoinery > 50)
                    {
                        priceSum = numJoinery * priceJoi;
                        priceSum *= 0.86;
                    }
                    break;

            }
            switch (typeDel)
            {
                case "With delivery":
                    priceSum += 60;
                    break;
                case "Without delivery":
                    break;
            }
            if (numJoinery < 10)
            {
                Console.WriteLine("Invalid order");

            }
            else if (numJoinery > 99)
            {
                priceSum *= 0.96;
                Console.WriteLine($"{priceSum:F2} BGN");
            }
            else
            {
                Console.WriteLine($"{priceSum:F2} BGN");
            }
        }
    }
}
