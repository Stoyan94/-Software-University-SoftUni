using System;

namespace _03_.Cat_Life
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string catType = Console.ReadLine();
            char sex = Console.ReadLine()[0];

            double catLife = 0;
            bool isCat = false;

            if (catType == "British Shorthair")
            {

                if (sex == 'm')
                {
                    catLife = 13 * 12;
                    catLife /= 6;
                    isCat = true;
                }
                else if (sex == 'f')
                {
                    catLife = 14 * 12;
                    catLife /= 6;
                    isCat = true;
                }
            }
            else if (catType == "Siamese")
            {

                if (sex == 'm')
                {
                    catLife = 15 * 12;
                    catLife /= 6;
                    isCat = true;
                }
                else if (sex == 'f')
                {
                    catLife = 16 * 12;
                    catLife /= 6;
                    isCat = true;
                }
            }
            else if (catType == "Persian")
            {

                if (sex == 'm')
                {
                    catLife = 14 * 12;
                    catLife /= 6;
                    isCat = true;
                }
                else if (sex == 'f')
                {
                    catLife = 15 * 12;
                    catLife /= 6;
                    isCat = true;
                }
            }
            else if (catType == "Ragdoll")
            {

                if (sex == 'm')
                {
                    catLife = 16 * 12;
                    catLife /= 6;
                    isCat = true;
                }
                else if (sex == 'f')
                {
                    catLife = 17 * 12;
                    catLife /= 6;
                    isCat = true;
                }
            }
            else if (catType == "American Shorthair")
            {

                if (sex == 'm')
                {
                    catLife = 12 * 12;
                    catLife /= 6;
                    isCat = true;
                }
                else if (sex == 'f')
                {
                    catLife = 13 * 12;
                    catLife /= 6;
                    isCat = true;
                }
            }
            else if (catType == "Siberian")
            {

                if (sex == 'm')
                {
                    catLife = 11 * 12;
                    catLife /= 6;
                    isCat = true;
                }
                else if (sex == 'f')
                {
                    catLife = 12 * 12;
                    catLife /= 6;
                    isCat = true;
                }
            }

            if (isCat)
            {
                Console.WriteLine($"{catLife} cat months");
            }
            else
            {
                Console.WriteLine($"{catType} is invalid cat!");
            }

        }
    }
}
