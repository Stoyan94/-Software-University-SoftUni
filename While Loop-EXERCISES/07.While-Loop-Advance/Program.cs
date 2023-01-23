using System;

namespace _07.While_Loop_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rest = double.Parse(Console.ReadLine());
            double coins = rest * 100;
            int count = 0;

            while (coins > 0)
            {
                if (coins >= 200)
                {
                    coins -= 200;
                    count++;
                    continue;
                }
                else if (coins >= 100)
                {
                    coins -= 100;
                    count++;
                    continue;
                }
                else if (coins >= 50)
                {
                    coins -= 50;
                    count++;
                    continue;
                }
                else if (coins >= 20)
                {
                    coins -= 20;
                    count++;
                    continue;
                }
                else if (coins >= 10)
                {
                    coins -= 10;
                    count++;
                    continue;
                }
                else if (coins >= 5)
                {
                    coins -= 5;
                    count++;
                    continue;
                }
                else if (coins >= 2)
                {
                    coins -= 2;
                    count++;
                    continue;
                }
                else if (coins >= 1)
                {
                    coins -= 1;
                    count++;
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
