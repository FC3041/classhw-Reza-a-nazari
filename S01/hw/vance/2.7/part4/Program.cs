using System;

namespace part4
{
    public class Program
    {
        public static int ghabel_ghesmat(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            if (a % b == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int is_prime(int n)
        {
            if (n <= 1)
            {
                return 0;
            }
            for (int x = 2; x < n; x++)
            {
                if (ghabel_ghesmat(n, x) == 1)
                {
                    return 0;
                }
            }
            return 1;
        }

        public static void Main()
        {
            Console.WriteLine("Prime numbers less than 100:");
            Console.WriteLine("----------------------------");

            for (int N = 2; N < 100; N++)
            {
                if (is_prime(N) == 1)
                {
                    Console.WriteLine(N);
                }
            }
        }
    }
}