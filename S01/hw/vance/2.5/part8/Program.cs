using System ;


namespace firstsample
{
    public class Program
    {
        public static float My_func_from_sefr(int numbersss)
        {
            int final = 0 ;
            for(int i=0 ; i<numbersss ; i++)
            {
                final += i*i ;
            }
            float nahaei = (float)final/numbersss ;
            return nahaei;
        }

        public static float My_func_from_yek(int numberss)
        {
            int finall = 0 ;
            for(int j=1 ; j<=numberss ; j++)
            {
                finall += j*j ;
            }
            float nahaeii = (float)finall/numberss;
            return nahaeii;
        }

        public static void Main()
        {
            int firstn = 5 ; 
            int secondn = 4 ;
            float h1 = My_func_from_sefr(firstn);
            float h2 = My_func_from_yek(secondn);
            Console.WriteLine("Dar Tabe e avali your number = 5 and javab = "+h1);
            Console.WriteLine("Dar Tabe e dovomi your number = 4 and javab = "+h2+"\n");

            if(h1==h2)
            {
                Console.WriteLine("They are same");
            }
            else if ( h1 !=h2)
            {
                Console.WriteLine("They are not same , chon avali az 0 ta n-1 va dovomi az 1 ta n");
            }
        }
        
    }
}