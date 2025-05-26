using System;

namespace part2
{
    public class Program
    {
        public static void Main()
        {
            int n = 10;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("%");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}