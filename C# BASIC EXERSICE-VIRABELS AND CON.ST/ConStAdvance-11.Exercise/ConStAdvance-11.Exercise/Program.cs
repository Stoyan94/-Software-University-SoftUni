using System;

namespace NewSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayVac = int.Parse(Console.ReadLine());
            dayVac -= 1;
            string room = Console.ReadLine();
            string opinion = Console.ReadLine();
            double roomPrice = 0;
            const double room1 = 18.00;
            const double apart = 25.00;
            const double president = 35.00;

            switch (room)
            {
                case "room for one person":
                    roomPrice = dayVac * room1;
                    break;
                case "apartment":
                    roomPrice = dayVac * apart;
                    if (dayVac < 10)
                    {
                        roomPrice *= 0.7;
                    }
                    else if (dayVac <= 15)
                    {
                        roomPrice *= 0.65;
                    }
                    else
                    {
                        roomPrice *= 0.5;
                    }
                    break;
                case "president apartment":
                    roomPrice = dayVac * president;
                    if (dayVac < 10)
                    {
                        roomPrice *= 0.9;
                    }
                    else if (dayVac <= 15)
                    {
                        roomPrice *= 0.85;
                    }
                    else
                    {
                        roomPrice *= 0.8;
                    }
                    break;

            }
            if (opinion == "positive")
            {
                roomPrice *= 1.25;
            }
            else if (opinion == "negative")
            {
                roomPrice *= 0.9;
            }
            Console.WriteLine($"{roomPrice:F2}");

        }
    }
}

