class Program
{
    static void C_to_F(int Cel)
    {
        float Faren = (Cel * 9f / 5) + 32;
        float round_shode = (float)Math.Round(Faren,2);
        Console.Write(round_shode) ;
    }

    static void Main()
    {
        int Cel = 67 ;
        C_to_F(Cel);
    }
}