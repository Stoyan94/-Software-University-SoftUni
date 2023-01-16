using System;

namespace NewSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (price <= 0 || price <= 500)
                {
                    double result = price - (price * 0.95);
                    Console.WriteLine($"{result:F2}"); ;
                }
                else if (price < 500 || price <= 1000)
                {
                    double result = price - (price * 0.93);
                    Console.WriteLine($"{result:F2}");
                }
                else if (price <= 1000 || price <= 10000)
                {
                    double result = price - (price * 0.92);
                    Console.WriteLine($"{result:F2}");

                }
                else if (price > 10000)
                {
                    double result = price - (price * 0.88);
                    Console.WriteLine($"{result:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            if (town == "Varna")
            {
                if (price <= 0 || price <= 500)
                {

                    double result = price - (price * 0.955);
                    Console.WriteLine($"{result:F2}"); ;
                }
                else if (price < 500 || price <= 1000)
                {
                    double result = price - (price * 0.925);
                    Console.WriteLine($"{result:F2}");
                }
                else if (price <= 1000 || price <= 10000)
                {
                    double result = price - (price * 0.90);
                    Console.WriteLine($"{result:F2}");
                }
                else if (price > 10000)
                {
                    double result = price - (price * 0.87);
                    Console.WriteLine($"{result:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            if (town == "Plovdiv")
            {
                if (price < 0)
                {
                    Console.WriteLine("error");
                }
                else if (price <= 0 || price <= 500)
                {
                    double result = price - (price * 0.945);
                    Console.WriteLine($"{result:F2}");
                }
                else if (price < 500 || price <= 1000)
                {
                    double result = price - (price * 0.92);
                    Console.WriteLine($"{result:F2}");
                }
                else if (price <= 1000 || price <= 10000)
                {
                    double result = price - (price * 0.88);
                    Console.WriteLine($"{result:F2}");
                }
                else if (price > 10000)
                {
                    double result = price - (price * 0.855);
                    Console.WriteLine($"{result:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            if (town != "Sofia" && town != "Varna" && town != "Plovdiv")
            {
                Console.WriteLine("error");
            }


        }
    }
}

