using System;


namespace part1
{
    public class Program
    {
        public static int absolute_val(int x)
        {
            if(x >= 0)
            {
                return x ;
            }
            else
            {
                return -x ;
            }
        }

        public static void Main()
        {
            int [] numbers = {-100, -1, 0, 1, 1000} ;
            int size = numbers.Length;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Ghadr motlagh  "  +numbers[i]  +"  is  "+  absolute_val(numbers[i])) ;
            }

        }
    }
}