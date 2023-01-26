using System;

namespace _05.Nested_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;

            bool isBigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int nums = 1; nums <= rows; nums++)
                {
                    if (current > n)
                    {
                        isBigger = true;

                        break;
                    }

                    Console.Write(current + " ");

                    current++;
                }

                if (isBigger)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
