using System;

namespace demo_15_min
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statis = int.Parse(Console.ReadLine());
            double oneStatPrice = double.Parse(Console.ReadLine());
            double dekor = (budget * 0.1);
            double budgetNeedet = budget * 0.1;

            if (statis > 150)
            {
                budgetNeedet += statis * oneStatPrice * 0.9;
            }
            else
            {
                budgetNeedet += statis * oneStatPrice;
            }
            if (budgetNeedet > budget)
            {
                double result = budgetNeedet - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {result:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                double result = budget - budgetNeedet;
                Console.WriteLine($"Wingard starts filming with {result:F2} leva left.");
            }
        }
    }
}
