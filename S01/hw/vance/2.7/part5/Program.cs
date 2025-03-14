using System;

namespace part5
{
    public class Program
    {
        public static void Main()
        {
            int n = 20;
            int first = 1, second = 1, next;

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.Write(first + " , ");
                    continue;
                }
                if (i == 2)
                {
                    Console.Write(second + " , ");
                    continue;
                }
                next = first + second;
                first = second;
                second = next;
                Console.Write(next + " , ");
            }

            Console.WriteLine(); 
        }
    }
}