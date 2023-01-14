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
            double meetersGrass = double.Parse(Console.ReadLine());

            double priceMeeterGrass = (7.61 * meetersGrass) * 0.82;
            double discount = meetersGrass * 7.61 * 0.68;
            Console.WriteLine($"The final price is :{priceMeeterGrass:F2} lv.");
            Console.WriteLine($"The discount is :{discount:F2} lv.");

        }
    }
}