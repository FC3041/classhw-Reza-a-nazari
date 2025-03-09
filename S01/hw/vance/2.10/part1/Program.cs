using System;

namespace part1
{
    public static class Program
    {
        public static void Main()
        {
            double precision = 0.0001;
            double e = Ec(precision);
            Console.WriteLine("ba deghat " + precision + " : " + e.ToString("F4"));//خدمت TA دکتر اعتمادی---->>>>>> F4= دقت 4
        }

        public static double Factorial(int n)
        {
            double result = 1.0;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static double Ec(double precision)
        {
            double e = 1.0;
            int n = 1;
            double term;

            while (true)
            {
                term = 1.0 / Factorial(n);
                if (term < precision)
                {
                    break;
                }
                e += term;
                n++;
            }

            return e;
        }
    }
}
