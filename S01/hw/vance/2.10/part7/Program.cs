using System;

namespace part7
{
    public class Program
    {
        public static double tavan(double meghdar_avalie, int tavan)
        {
            double res = 1.0;
            for (int i = 0; i < tavan; i++)
            {
                res *= meghdar_avalie;
            }
            return res;
        }

        public static double ln(double x, double deghat)
        {
            if (x <= 0) 
            {
                return -1; 
            }

            double ghabl_baand = 0.0;
            double bala_baand = x;
            double vasat;
            int tedad_tkrar = 0;

            while ((bala_baand - ghabl_baand) > deghat)
            {
                vasat = (ghabl_baand + bala_baand) / 2;
                if (tavan(Math.E, (int)vasat) < x)
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
            double x = 2.0;
            double deghat = 0.000001;
            double natije = ln(x, deghat);
            Console.WriteLine("Log tabie " + x + " ba deghat " + deghat + " : " + natije);
        }
    }
}
