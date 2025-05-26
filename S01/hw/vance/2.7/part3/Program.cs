using System;

namespace part3
{
    public class Program
    {
        public static int is_divisible(int a, int b)
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

        public static void Main()
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            if (is_divisible(a, b) == 1)
            {
                Console.WriteLine(a + " is divisible by  " + b);
            }
            else
            {
                Console.WriteLine( a + " is not divisible by " + b);
            }
        }
    }
}