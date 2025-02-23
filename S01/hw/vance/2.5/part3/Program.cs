class Program
{
    static void Factoriel(int number)
    {
        int final = 1 ; 
        for(int i = 1 ; i<number+1 ; i++)
        {
            final *=i ;
        }

        Console.Write(final);
    }

    static void Main()
    {
        int panj = 5 ; 
        Factoriel(panj);
    }
}
