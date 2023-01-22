using System;

namespace _07.Exercise_ForLoop_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                string TabOpen = Console.ReadLine();

                if (TabOpen == "Facebook")
                {
                    salary -= 150;
                }
                else if (TabOpen == "Instagram")
                {
                    salary -= 100;
                }
                else if (TabOpen == "Reddit")
                {
                    salary -= 50;
                }
                else if (salary == 0)
                {
                    break;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
