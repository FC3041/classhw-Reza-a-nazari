using System;

namespace part5
{
    public class Program
    {
        public static double mosavi_square_root(double x, double deghat)
        {
            if (x < 0)
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
                if (vasat * vasat < x)
                {
                    ghabl_baand = vasat;
                }
                else
                {
                    bala_baand = vasat;
                }
                tedad_tkrar++;
            }

            Console.WriteLine("Tedaad Takrar: " + tedad_tkrar);
            return (ghabl_baand + bala_baand) / 2;
        }

        public static void Main()
        {
            double x = 2.0;
            double deghat = 0.000001;
            double natije = mosavi_square_root(x, deghat);
            Console.WriteLine("Rishhaye morabba-ye " + x + " ba deghat " + deghat + " : " + natije);
        }
    }
}
