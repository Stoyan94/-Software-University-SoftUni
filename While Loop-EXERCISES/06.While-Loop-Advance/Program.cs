using System;

namespace _06.While_Loop_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string home = Console.ReadLine();

            double steps = 0;
            double goal = 10000;

            double currentStep = 0;

            while (home != "Going home")
            {
                steps = double.Parse(home);
                currentStep += steps;


                if (currentStep > goal)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{currentStep - goal} steps over the goal!");

                    return;
                }
                home = Console.ReadLine();

            }
            double stepHome = double.Parse(Console.ReadLine());

            currentStep += stepHome;

            if (currentStep > goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{currentStep - goal} steps over the goal!");
            }
            else
            {

                Console.WriteLine($"{goal - currentStep} more steps to reach goal.");
            }
        }
    }
}
