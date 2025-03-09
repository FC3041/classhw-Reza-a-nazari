

class Program
{
    static void My_func(int numbersss)
    {
        int final = 0 ;
        for(int i=0 ; i<numbersss ; i++)
        {
            final += i*i ;
        }

        float nahaei = (float)final/numbersss ;
        Console.WriteLine(nahaei);
    }

    static void Main()
    {
        int myadad = 5 ;
        My_func(myadad);
    }

}