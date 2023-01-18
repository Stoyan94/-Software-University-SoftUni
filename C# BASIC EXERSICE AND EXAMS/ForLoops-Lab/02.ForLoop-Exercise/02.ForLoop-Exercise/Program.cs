using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rigthSum = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    leftSum += num;
                }

                else
                {
                    rigthSum += num;
                }
            }
            if (leftSum == rigthSum)
            {

                Console.WriteLine($" Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($" No, diff = {Math.Abs(leftSum - rigthSum)}");
            }


        }
    }
}
