using System;

namespace part4
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

        public static double factorial(int n)
        {
            double res = 1.0;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        public static double sin(double x, double deghat)
        {
            double rad = x * Math.PI / 180.0;
            double res = 0.0;
            double jomle = rad;
            int n = 1;
            int alamt = 1;

            while (ghadr_meghdar(jomle) >= deghat)
            {
                res += jomle;
                n += 2;
                alamt = -alamt;
                jomle = alamt * Math.Pow(rad, n) / factorial(n);
            }

            return res;
        }

        static void Main()
        {
            double deghat = 0.0001;
            double sin45 = sin(45, deghat);
            double sin90 = sin(90, deghat);
            double sin0 = sin(0, deghat);

            Console.WriteLine("Sin(45 daraje) = " + sin45);
            Console.WriteLine("Sin(90 daraje) = " + sin90);
            Console.WriteLine("Sin(0 daraje) = " + sin0);
        }
    }
}
