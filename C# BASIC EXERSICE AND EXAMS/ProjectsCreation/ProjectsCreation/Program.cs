using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CatalogVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameArhi = Console.ReadLine();
            int numProjects = int.Parse(Console.ReadLine());

            int hoursForProject = numProjects * 3;

            Console.WriteLine($"The architect {nameArhi} will need {hoursForProject} " +
                $"hours to complete {numProjects} project/s.");

        }
    }
}