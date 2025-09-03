using System ;


namespace part2
{
    public class Program
    {
        public static double tavan(double v , int c)
        {
            double res = 1.0 ; 
            for(int i=0 ; i<c ; i++)
            {
                res*=v ;

            }
            return res ; 
        }
        public static double factoriel(int n)
        {
            double final = 1.0 ;
            for(int i=1 ; i<=n ; i++)
            {
                final*=i ;
            }

            return final ;

        }
        public static double myfunc(double x , double deghat)
        {
            double j_nahaei = 1.0 ; 
            int n = 1 ;
            double jomle ; 

            while(true)
            {
                jomle = 1.0/factoriel(n);
                if(jomle<deghat)
                {
                    break ; 
                }
                j_nahaei += jomle;
                n++;

            }
            return j_nahaei ;
        }
        public static int Main()
        {
            double x = 1.0 ; 
            double deghat =    0.000001 ; 
            double deghat_khaste_shode = 0.000001;
            double e = myfunc(x,deghat);
            double round_shode = Math.Round(e,4);
            double x1 = tavan(e,1);
            double x2 = tavan(e,2);
            double rounded_x1 = Math.Round(x1,6);
            double rounded_x2 = Math.Round(x2,6);

            Console.WriteLine("ba deghat " + deghat_khaste_shode + " : " + round_shode);
            Console.WriteLine("ba deghat " + deghat_khaste_shode + " e be tavan 1"  + " : " + rounded_x1);
            Console.WriteLine("ba deghat " + deghat_khaste_shode + "e be tavan 2 " + ": " + rounded_x2);

            return 0 ;
            

        }
    }
}