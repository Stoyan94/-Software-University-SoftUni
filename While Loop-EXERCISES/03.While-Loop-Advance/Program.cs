using System;

namespace _03.While_Loop_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookSearch = Console.ReadLine();
            int countBook = 0;
            bool isFound = false;
            string booksCeck = Console.ReadLine();

            while (booksCeck != "No More Books")
            {
                if (booksCeck == bookSearch)
                {
                    isFound = true;
                    break;
                }
                else
                {
                    countBook++;
                }
                booksCeck = Console.ReadLine();
            }


            if (isFound)
            {
                Console.WriteLine($"You checked {countBook} books and found it.");

            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countBook} books.");
            }
        }
    }
}
