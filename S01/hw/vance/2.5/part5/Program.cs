class Program
{
    static void tavan_yek_adad(int adad , int tavan)
    {
        int final = 1 ;
        for (int i=0 ; i<tavan ; i++)
        {
            final *=adad ;
        }
        Console.Write(final);
    }

    static void Main()
    {
        int adad = 2 ;
        int tavan = 3 ;
        tavan_yek_adad(adad,tavan);
    }
}