using System;

namespace _06.Nested_Loops_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                int currentNum = i;

                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < 6; j++)
                {
                    int digit = currentNum % 10;

                    if (j % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    currentNum /= 10;
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
