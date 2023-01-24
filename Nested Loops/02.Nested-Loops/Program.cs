using System;

namespace _02.Nested_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combo = 0;
            bool isMagicNum = false;

            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    combo++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combo} ({i} + {j} = {magicNum})");
                        isMagicNum = true;
                        break;
                    }


                }
                if (isMagicNum)
                {
                    break;
                }
            }
            if (!isMagicNum)
            {
                Console.WriteLine($"{combo} combinations - neither equals {magicNum}");
            }
        }
    }
}
