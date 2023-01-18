using System;

namespace _01.ForLoop_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volSum = 0;

            for (int i = 0; i < name.Length; i++)
            {

                char letter = name[i];

                switch (letter)
                {
                    case 'a':
                        volSum += 1;
                        break;
                    case 'e':
                        volSum += 2;
                        break;
                    case 'i':
                        volSum += 3;
                        break;
                    case 'o':
                        volSum += 4;
                        break;
                    case 'u':
                        volSum += 5;
                        break;

                }
            }
            Console.WriteLine(volSum);
        }
    }
}
