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
            double numChek = double.Parse(Console.ReadLine());

            if (numChek <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (numChek > 10 & numChek <= 50)
            {
                Console.WriteLine("average");
            }
            else if (numChek > 50 & numChek <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (numChek > 150 & numChek <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }



        }
    }
}