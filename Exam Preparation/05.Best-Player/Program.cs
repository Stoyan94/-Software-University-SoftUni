using System;

namespace _05.Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            double goalsScore = 0;
            string bestPlayr = "";

            while (playerName != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (goals == goalsScore)
                {
                    break;
                }
                else if (goals >= 10)
                {
                    bestPlayr = playerName;
                    goalsScore = goals;
                    break;
                }
                else if (goals >= 3 && goals < 10)
                {
                    bestPlayr = playerName;
                    goalsScore = goals;
                }
                else if (goals < 3)
                {
                    bestPlayr = playerName;
                    goalsScore = goals;
                }
                playerName = Console.ReadLine();

            }
            Console.WriteLine($"{bestPlayr} is the best player!");

            if (goalsScore < 3)
            {
                Console.WriteLine($"He has scored {goalsScore} goals.");
            }
            else if (goalsScore >= 3 && goalsScore < 10)
            {
                Console.WriteLine($"He has scored {goalsScore} goals and made a hat-trick !!!");
            }
            else if (goalsScore >= 10)
            {
                Console.WriteLine($"He has scored {goalsScore} goals and made a hat-trick !!!");
            }
        }
    }
}
