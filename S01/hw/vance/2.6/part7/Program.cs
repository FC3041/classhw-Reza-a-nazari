using System;

namespace part7
{
    public class Program
    {
        public static void Main()
        {
            for (int a = 1; a < 100; a++)
            {
                for (int b = a + 1; b < 100; b++)
                {
                    for (int c = b + 1; c < 100; c++)
                    {
                        if (a * a + b * b == c * c)
                        {
                            Console.WriteLine($"({a}, {b}, {c})");
                        }
                    }
                }
            }
        }
    }
}
