using System;

namespace part6
{
    public class Program
    {
        public static int d_m(int Mnumb)
        {
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (Mnumb >= 1 && Mnumb <= 12)
            {
                return days[Mnumb - 1];
            }
            else
            {
                return -1;
            }
        }

        public static void Main()
        {
            Console.Write("shomare maah: ");
            int month = int.Parse(Console.ReadLine());

            int days = d_m(month);

            if (days == -1){
                Console.WriteLine("Mah na motabar");
            }
            else
            {
                Console.WriteLine(month + ":"+days);
            }
        }
    }
}