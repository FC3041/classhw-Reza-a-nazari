using System;

namespace part3
{
    public class Program
    {
        public static void Main()
        {
            int n = 4;

            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("^");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("/");
                }

                Console.Write("|");

                for (int j = 0; j < i; j++)
                {
                    Console.Write("\\");
                }

                Console.WriteLine();
            }
        }
    }
}