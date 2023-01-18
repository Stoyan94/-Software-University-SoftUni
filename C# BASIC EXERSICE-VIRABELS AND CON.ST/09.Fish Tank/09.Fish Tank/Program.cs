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
            int lenght = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double procentSpace = double.Parse(Console.ReadLine()) / 100;

            double spaceAcvarium = lenght * widht * hight;
            double kubMeters = spaceAcvarium / 1000;
            double spaceForWater = kubMeters - (kubMeters * procentSpace);

            Console.WriteLine(spaceForWater);




        }
    }
}