using System;

namespace _04.Gold_Mine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allLocations = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < allLocations; i++)
            {
                int averageDayGold = int.Parse(Console.ReadLine());
                int currLocationDays = int.Parse(Console.ReadLine());
                
                double currAverageGold = 0;
                
                for (int j = 0; j < currLocationDays; j++)
                {
                    int currGoldDig = int.Parse(Console.ReadLine());

                    currAverageGold += currGoldDig; 
                }
                
                
                double average =(double)currAverageGold / currLocationDays;
                if (average>averageDayGold)
                {
                    Console.WriteLine($"Good job! Averge gold per day {average:F2}.");
                }
                else
                {
                    
                    Console.WriteLine($"You need {averageDayGold-average:F2} gold.");
                }
            }
        }
    }
}
