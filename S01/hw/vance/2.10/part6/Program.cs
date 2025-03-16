using System;

namespace part6
{
    public class Program
    {
        public static double tavan(double meghdar_avalie, int exponent)
        {
            double result = 1.0;
            for (int i = 0; i < exponent; i++)
            {
                result *= meghdar_avalie;
            }
            return result;
        }

        public static double rishe(double x, int n, double deghat)
        {
            if (x < 0 && n % 2 == 0)
            {
                return -1;
            }
            

            double ghabl_baand = 0;
            double bala_baand = x;
            double vasat;
            int tedad_tkrar = 0;

            while ((bala_baand - ghabl_baand) > deghat)
            {
                vasat = (ghabl_baand + bala_baand) / 2;
                if (tavan(vasat, n) < x)
                {
                    ghabl_baand = vasat;
                }
                else
                {
                    bala_baand = vasat;
                }
                tedad_tkrar++;
            }

            Console.WriteLine("Tedad Takrar: " + tedad_tkrar);
            return (ghabl_baand + bala_baand) / 2;
        }

        public static void Main()
        {
            double x = 8.0;
            int n = 3;
            double deghat = 0.000001;
            double natije = rishe(x, n, deghat);
            Console.WriteLine(n + "am khorooj rishhaye " + x + " ba deghat " + deghat + " : " + natije);
        }
    }
}
