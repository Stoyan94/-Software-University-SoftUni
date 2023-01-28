using System;

namespace _09.Nested_Loops_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            for (int i = 1111; i < 9999; i++)
            {
                int currentNum = i;
                bool isSpecial = true;

                for (int j = 0; j < 4; j++)
                {
                    double digit = currentNum % 10;

                    if (num % digit == 0)
                    {

                    }
                    else if (num % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    currentNum /= 10;
                }

                if (isSpecial)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
