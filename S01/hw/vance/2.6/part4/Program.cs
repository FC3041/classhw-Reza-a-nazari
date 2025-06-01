using System;

namespace part4
{
    public class Program
    {
        public static void PrintCone(int size)
        {
            if (size % 2 == 0)
            {
                Console.WriteLine("Error.");
                return;
            }

            int spaces = size / 2;
            int slashes = 1;

            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("^");

            for (int i = 1; i <= size / 2; i++)
            {
                for (int j = 0; j < spaces - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < slashes; j++)
                {
                    Console.Write("/");
                }

                Console.Write("|");

                for (int j = 0; j < slashes; j++)
                {
                    Console.Write("\\");
                }

                Console.WriteLine();
                slashes++;
            }
        }

        public static void Main()
        {
            for (int i = 1; i <= 9; i += 2)
            {
                Console.WriteLine($" {i}:");
                PrintCone(i);
                Console.WriteLine();
            }
        }
    }
}