using System;

namespace _04.While_Loop_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failGrades = int.Parse(Console.ReadLine());
            int failGradesCount = 0;
            int dunExcount = 0;
            double gradesSum = 0;
            string task = "";
            bool isFaild = true;

            while (failGradesCount < failGrades)
            {
                string problemName = Console.ReadLine();
                if ("Enough" == problemName)
                {
                    isFaild = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failGradesCount++;
                }

                gradesSum += grade;
                dunExcount++;
                task = problemName;
            }
            if (isFaild)
            {
                Console.WriteLine($"You need a break, {failGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / dunExcount:F2}");
                Console.WriteLine($"Number of problems: {dunExcount}");
                Console.WriteLine($"Last problem: {task}");
            }
        }
    }
}
