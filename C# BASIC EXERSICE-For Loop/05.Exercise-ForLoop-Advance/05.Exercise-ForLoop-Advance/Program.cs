using System;

namespace _05.Exercise_ForLoop_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if (num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            double p1Pre, p2Pre, p3Pre, p4Pre, p5Pre;
            p1Pre = (double)p1 / n * 100;
            p2Pre = (double)p2 / n * 100;
            p3Pre = (double)p3 / n * 100;
            p4Pre = (double)p4 / n * 100;
            p5Pre = (double)p5 / n * 100;

            Console.WriteLine($"{p1Pre:F2}%");
            Console.WriteLine($"{p2Pre:F2}%");
            Console.WriteLine($"{p3Pre:F2}%");
            Console.WriteLine($"{p4Pre:F2}%");
            Console.WriteLine($"{p5Pre:F2}%");
        }
    }
}
