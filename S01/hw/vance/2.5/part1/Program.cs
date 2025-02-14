class Program
{
    static void F_to_C(int Fahrenheit)
    {
        float celcious = ( Fahrenheit -32)* 5f/9 ;
        float round_shode = (float)Math.Round(celcious,2);
        Console.Write(round_shode) ;
    }

    static void Main()
    {
        int Faren = 67 ;
        F_to_C(Faren);
    }
}