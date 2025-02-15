class Program
{
    static void head_moshak(int size)
    {
        for(int k=0 ; k<size ; k++)
        {
            Console.Write(" ");
            if(k==size-1)
            {
                Console.Write("^\n");
            }
        }
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size - i - 1; j++) {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++) {
                Console.Write("/");
            }
            Console.Write("|");
            for (int j = 0; j <= i; j++) {
                Console.Write("\\");
            }
            Console.Write("\n");
        }
    }

    static void joda_konandeh(int arz)
    {
        Console.Write("+");
        for (int i = 0; i < arz; i++)
        {
            Console.Write("-");
        }
        Console.Write("+\n");
    }

    static void badaneh_moshak(int arz , int ertefa)
    {
        for (int i = 0; i < ertefa; i++) 
        {
            Console.Write("+");
            for (int j = 0; j < arz; j++) 
            {
                Console.Write("*");
            }
            Console.Write("+\n");
        }
    }

    static void Main()
    {
        int size = 4 ; 
        int arz = 7 ;
        int ertefa = 4 ;
        head_moshak(size);
        joda_konandeh(arz);
        badaneh_moshak(arz,ertefa);
        joda_konandeh(arz);
        badaneh_moshak(arz,ertefa);
        joda_konandeh(arz);
        head_moshak(size);

    }
}

