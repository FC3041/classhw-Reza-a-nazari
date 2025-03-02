
class Program
{
    static void calculate_rishe(int a , int b , int c)
    {
        float delta = (b*b) - (4 * a *c);
        float rad = (float)Math.Sqrt(delta);
        float rishe_1 = ((-b) + rad) / (a * 2f);
        float rishe_2 = ((-b) - rad) / (a * 2f);
        Console.WriteLine("rishe haye aval shoma = " + rishe_1);
        Console.WriteLine("rishe haye dovom shoma = " + rishe_2);
        
    }

    static void Main ()
    {
        int A = 1;
        int B = 4;
        int C = 3;
        calculate_rishe(A,B,C);
    }
}
