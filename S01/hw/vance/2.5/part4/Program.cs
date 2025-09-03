class Program
{
    static void Factoriel(int number)
    {
        long final = 1 ; 
        for(int i = 1 ; i<number+1 ; i++)
        {
            final *=i ;
            Console.WriteLine(final);
        } 
    }

    static void Main()
    {
        int bist = 20 ; 
        Factoriel(bist);
    }
}
