using System;

namespace _08.Nested_Loops_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juri = int.Parse(Console.ReadLine());  
            string present = Console.ReadLine();

            double studentDegree = 0;

            double presentSum = 0;
            double evaluationSum = 0;

            while (present != "Finish")
            {

                for (double i = 0; i < juri; i++)
                {
                    double evaluation = double.Parse(Console.ReadLine());

                    studentDegree += evaluation;
                    presentSum += evaluation;

                    evaluationSum++;
                }

                double precentageDegree = (double)studentDegree / juri;

                Console.WriteLine($"{present} - {precentageDegree:F2}.");

                studentDegree = 0;
                present = Console.ReadLine();
            }

            double averageSum = presentSum / evaluationSum;
            Console.WriteLine($"Student's final assessment is {averageSum:F2}.");
        }
    }
}
