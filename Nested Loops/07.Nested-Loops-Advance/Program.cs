using System;

namespace _07.Nested_Loops_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primesSum = 0, nonprimeSum = 0;
            string number = Console.ReadLine();

            while (number != "stop")
            {
                int digit = int.Parse(number);
                if (digit < 0)
                {
                    Console.WriteLine("Number is negative.");
                    number = Console.ReadLine();
                    continue;
                }
                bool isPrime = true;
                for (int i = 2; i < digit; i++)
                {
                    if (digit % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primesSum += digit;
                }
                else
                {
                    nonprimeSum += digit;
                }
                number = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primesSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprimeSum}");
        }
    }
}
