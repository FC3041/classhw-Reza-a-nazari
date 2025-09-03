using System;

namespace part3A
{
    class Program
    {
        public static double ghadr_meghdar(double x)
        {
            if (x < 0)
            {
                return -x;
            }
            else
            {
                return x;
            }
        }

        public static bool nazdik(double x, double y, double nazdiki)
        {
            double max = Math.Max(ghadr_meghdar(x), ghadr_meghdar(y));
            double tafavot = ghadr_meghdar(x - y);
            return tafavot <= (nazdiki * max);
        }

        static void Main(string[] args)
        {
            double x = 1.0;
            double y = 1.001;
            double nazdiki = 0.001;

            if (nazdik(x, y, nazdiki))
            {
                Console.WriteLine(x + " va " + y + " be ham nazdikan kamtar az yek darsad");
            }
            else
            {
                Console.WriteLine(x + " va " + y + " be ham nazdik nistan");
            }
        }
    }
}
