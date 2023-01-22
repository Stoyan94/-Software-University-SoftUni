using System;

namespace _01.While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int grades = 1;
            double currentGrade = 0;
            double grageSum = 0;
            bool graduated = true;
            int fail = 0;

            while (grades <= 12)
            {
                currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade < 4)
                {
                    fail++;
                    if (fail > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {grades} grade");
                        graduated = false;
                        break;
                    }
                    continue;
                }
                grageSum += currentGrade;
                grades++;
            }

            if (graduated)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {(grageSum / 12):F2}");
            }
        }
    }
}
