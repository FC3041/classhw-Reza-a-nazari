using System;

namespace part3
{
    class Program
    {
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

        static void Main(string[] args)
        {
            double x = 1.0;
            double deghat = 0.0001;
            double exp_x = Exp2(x, deghat);
            Console.WriteLine("e^x ba deghat " + deghat + " : " + exp_x.ToString("F10"));
        }
    }
}
