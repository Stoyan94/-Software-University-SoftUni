using System;

namespace _10.Nested_Loops_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            double studentTicket = 0;
            double standardTicket = 0;
            double kidTicket = 0;

            double totoalTicket = 0;

            while (movieName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());

                int cuurentTicket = 0;

                for (int i = 0; i < freeSeats; i++)
                {
                    string typeBilets = Console.ReadLine();

                    if (typeBilets == "End")
                    {
                        break;
                    }
                    switch (typeBilets)
                    {
                        case "student":
                            studentTicket += 1;
                            break;
                        case "standard":
                            standardTicket += 1;
                            break;
                        case "kid":
                            kidTicket += 1;
                            break;

                    }

                    cuurentTicket++;
                   
                }
                totoalTicket += cuurentTicket;

                double percentHall = (double)cuurentTicket / freeSeats * 100;

                Console.WriteLine($"{movieName} - {percentHall:F2}% full.");
                movieName = Console.ReadLine();

            }

            double percentStandard = (double)standardTicket / totoalTicket * 100;
            double percentKid = (double)kidTicket / totoalTicket * 100;
            double percentStudent = (double)studentTicket / totoalTicket * 100;

            Console.WriteLine($"Total tickets: {totoalTicket}");
            Console.WriteLine($"{percentStudent:F2}% student tickets.");
            Console.WriteLine($"{percentStandard:F2}% standard tickets.");
            Console.WriteLine($"{percentKid:F2}% kids tickets.");
        }
    }
}
