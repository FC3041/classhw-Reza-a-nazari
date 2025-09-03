using System ;

namespace part2
{
using System;

namespace part2
{
    public class Program
    {
        public static int Fact(int N)
        {
            int result = 1;
            for (int i = 1; i <= N; i++)
            {
                result *= i;
            }
            return result;
        }

        public static void Main()
        {
            Console.WriteLine("N\tN!");
            Console.WriteLine("----------------");

            for (int N = 1; N <= 10; N++)
            {
                Console.WriteLine($"{N}\t{Fact(N)}");
            }
        }
    }
}
}