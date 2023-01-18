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
            int penPackets = int.Parse(Console.ReadLine());
            int markerPackets = int.Parse(Console.ReadLine());
            int bordCleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double totalSum = (penPackets * 5.80) + (markerPackets * 7.20) + (bordCleaner * 1.20);

            double finalDiscount = totalSum - (totalSum * ((double)discount / 100));

            Console.WriteLine(finalDiscount);


        }
    }
}