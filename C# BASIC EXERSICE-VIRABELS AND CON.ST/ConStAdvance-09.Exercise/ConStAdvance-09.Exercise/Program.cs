using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMin;
            int arriveTime = arriveHour * 60 + arriveMin;
            int difference = examTime - arriveTime;

            if (difference > 30)
            {
                Console.WriteLine("Early");
            }
            else if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }

            if (difference < 60 && difference > 0)
            {
                Console.WriteLine($"{difference} minutes before the start");
            }
            else if (difference >= 60)
            {
                int resultHour = difference / 60;
                int resultMin = difference % 60;
                if (resultMin >= 10)
                {
                    Console.WriteLine($"{resultHour}:{resultMin} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{resultHour}:0{resultMin} hours before the start");
                }
            }
            else if (difference > -60 && difference < 0)
            {
                Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
            }
            else if (difference <= 60)
            {
                int resultHour = Math.Abs(difference) / 60;
                int resultMin = Math.Abs(difference) % 60;
                if (resultMin >= 10)
                {
                    Console.WriteLine($"{resultHour}:{resultMin} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{resultHour}:0{resultMin} hours after the start");
                }
            }
        }
    }
}
