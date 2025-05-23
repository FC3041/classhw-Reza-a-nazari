using System;

namespace part7
{
    public class Program
    {
        public static bool aya_leap(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0));
        }

        public static int d_in_m(int year, int Mnumber)
        {
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (Mnumber == 2 && aya_leap(year))
            {
                return 29;
            }
            if (Mnumber >= 1 && Mnumber <= 12)
            {
                return days[Mnumber - 1];
            }
            else
            {
                return -1;
            }
        }

        public static void Main()
        {
            Console.Write("Yek sal vared konid: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Shomare mah ra vared konid (1=Farvardin, 12=Esfand): ");
            int month = int.Parse(Console.ReadLine());

            int days = d_in_m(year, month);

            if (days == -1)
            {
                Console.WriteLine("Khatta.");
            }
            else
            {
                Console.WriteLine("Tedad rooz haye mah " + month + " sal " + year + " barabar ast ba " + days);
            }
        }
    }
}