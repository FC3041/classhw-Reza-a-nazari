class Program
{
    static void print_stars_from_chap_ta_rast(int number)
    {
        int j = 0;
        for(int i=0 ; i<number+1 ; i++)
        {
            while(j<i)
            {
                Console.Write("*");
                j++ ;
                if(j==i)
                {
                    Console.Write("\n");
                }
            }
            j = 0 ;
        }
    }
    static void Main()
    {
        int number = 20 ;
        print_stars_from_chap_ta_rast(number);
    }
}