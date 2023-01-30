using System;

namespace _04.Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ballNum = int.Parse(Console.ReadLine());
            double ballPoints = 0;
           
            double red = 0;
            double orange = 0;
            double yellow = 0;
            double white = 0;
            double black = 0;
            double otherColors = 0;

            for (int i = 0; i < ballNum; i++)
            {
                string ballColor = Console.ReadLine();

                switch (ballColor)
                {
                    case "red":
                        ballPoints += 5;
                        red++;
                        continue;

                    case "orange":
                        ballPoints += 10;
                        orange++;
                        continue;

                    case "yellow":
                        ballPoints += 15;
                        yellow++;
                        continue;

                    case "white":
                        ballPoints += 20;
                        white++;
                        continue;

                    case "black":
                        ballPoints = Math.Floor(ballPoints / 2);
                        black++;
                        continue;

                }

                otherColors++;
            }
            Console.WriteLine($"Total points: {ballPoints}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {otherColors}");
            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}
