using System;

namespace part3B
{
    class Program
    {
        public static double Exp(double x, double deghat)
        {
            double result = 1.0;
            double jomle = 1.0;
            int n = 1;

            while (true)
            {
                jomle *= x / n;
                if (Math.Abs(jomle) < deghat)
                {
                    break;
                }
                result += jomle;
                n++;
            }

            return result;
        }

        public static double Exp2(double x, double deghat)
        {
            double result = 1.0;
            double jomle = 1.0;
            int n = 1;

            while (true)
            {
                jomle *= x / n;
                if (Math.Abs(jomle) < deghat)
                {
                    break;
                }
                result += jomle;
                n++;
            }

            return result;
        }

        public static bool Near(double a, double b, double nazdiki)
        {
            return Math.Abs(a - b) < nazdiki;
        }

        static void Main()
        {
            double x = 1.0;
            double deghat = 0.0001;
            double nazdiki = 0.00001;
            double exp_x = Exp(x, deghat);
            double exp2_x = Exp2(x, deghat);
            if (Near(exp_x, exp2_x, nazdiki))
            {
                Console.WriteLine(exp_x + "   va   " +  exp2_x+ " be ham nazdikan kamtar az nazdiki.");
            }
            else
            {
                Console.WriteLine(exp_x + "   va   " +  exp2_x+  "be ham nazdik nistan.");
            }
        }
    }
}
