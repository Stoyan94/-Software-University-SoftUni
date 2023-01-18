using System;

namespace NewSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());

            double priceApart = 0;
            double priceStuiod = 0;

            const double mayStudio = 50;
            const double mayApart = 65;

            const double octStudio = 50;
            const double octApart = 65;

            const double junStudio = 75.20;
            const double junApart = 68.70;

            const double septStudio = 75.20;
            const double sepApart = 68.70;

            const double julStudio = 76;
            const double julApart = 77;

            const double augStudio = 76;
            const double augApart = 77;

            switch (month)
            {
                case "May":

                    if (numNights > 7 && numNights <= 14)
                    {
                        priceStuiod = numNights * mayStudio * 0.95;
                        priceApart = numNights * mayApart;
                    }
                    else if (numNights > 14)
                    {
                        priceStuiod = numNights * mayStudio * 0.70;
                        priceApart = numNights * mayApart * 0.90;
                    }
                    else
                    {
                        priceStuiod = numNights * mayStudio;
                        priceApart = numNights * mayApart;
                    }
                    Console.WriteLine($"Apartment: {priceApart:F2} lv.");
                    Console.WriteLine($"Studio: {priceStuiod:F2} lv.");
                    break;

                case "October":

                    if (numNights > 7 && numNights <= 14)
                    {
                        priceApart = numNights * octApart;
                        priceStuiod = numNights * octStudio * 0.95;
                    }
                    else if (numNights > 14)
                    {
                        priceStuiod = numNights * octStudio * 0.70;
                        priceApart = numNights * octApart * 0.90;
                    }
                    else
                    {
                        priceStuiod = numNights * octStudio;
                        priceApart = numNights * octApart;
                    }
                    Console.WriteLine($"Apartment: {priceApart:F2} lv.");
                    Console.WriteLine($"Studio: {priceStuiod:F2} lv.");
                    break;

                case "June":

                    if (numNights > 14)
                    {
                        priceStuiod = numNights * junStudio * 0.80;
                        priceApart = numNights * junApart * 0.90;
                    }
                    else
                    {
                        priceStuiod = numNights * junStudio;
                        priceApart = numNights * junApart;
                    }
                    Console.WriteLine($"Apartment: {priceApart:F2} lv.");
                    Console.WriteLine($"Studio: {priceStuiod:F2} lv.");
                    break;

                case "September":

                    if (numNights > 14)
                    {
                        priceStuiod = numNights * septStudio * 0.80;
                        priceApart = numNights * sepApart * 0.90;
                    }
                    else
                    {
                        priceStuiod = numNights * septStudio;
                        priceApart = numNights * sepApart;
                    }
                    Console.WriteLine($"Apartment: {priceApart:F2} lv.");
                    Console.WriteLine($"Studio: {priceStuiod:F2} lv.");
                    break;

                case "July":

                    if (numNights > 14)
                    {
                        priceApart = numNights * julApart * 0.90;
                    }
                    else
                    {
                        priceApart = numNights * julApart;
                    }
                    priceStuiod = numNights * julStudio;
                    Console.WriteLine($"Apartment: {priceApart:F2} lv.");
                    Console.WriteLine($"Studio: {priceStuiod:F2} lv.");
                    break;

                case "August":

                    if (numNights > 14)
                    {
                        priceApart = numNights * augApart * 0.90;
                    }
                    else
                    {
                        priceApart = numNights * augApart;
                    }

                    priceStuiod = numNights * augStudio;
                    Console.WriteLine($"Apartment: {priceApart:F2} lv.");
                    Console.WriteLine($"Studio: {priceStuiod:F2} lv.");
                    break;

            }
        }
    }
}

