using System;

namespace part5
{
    public class Program
    {
        public static void PrintMonth(int monthNum)
        {
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            if (monthNum >= 1 && monthNum <= 12)
            {
                Console.WriteLine($"| {monthNum,2} | {months[monthNum - 1],-3} |");
            }
        }

        public static void Main()
        {
            Console.WriteLine("+----+-----+");
            Console.WriteLine("| Num | Mon |");
            Console.WriteLine("+----+-----+");

            for (int i = 1; i <= 12; i++)
            {
                PrintMonth(i);
            }

            Console.WriteLine("+----+-----+");
        }
    }
}
