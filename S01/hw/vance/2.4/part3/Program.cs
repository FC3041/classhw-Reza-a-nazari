class Program
{
    static void rev_triangle(int main)
    {
        for (int i=1; i<=5 ; i++)
        {
            for(int j=1 ; j<=5-i ; j++ )
            {
                Console.Write(" ");
            }
            for ( int j = 1 ; j<=i ; j++) 
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
    static void Main()
    {
        int number1 = 6 ;
        rev_triangle(number1);
    }
}