﻿using System;

namespace NewSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string timeDay = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (degrees >= 10 && degrees <= 18)
            {
                if (timeDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeDay == "Afternoon" || timeDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }

            else if (degrees < 18 || degrees <= 24)
            {
                if (timeDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }
            else if (degrees >= 25)
            {
                if (timeDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }




        }


    }
}

