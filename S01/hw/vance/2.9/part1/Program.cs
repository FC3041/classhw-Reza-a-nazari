using System;
using System.Diagnostics;
class Program
{
    static bool IsPrime(int N)
    {
        if (N <= 1)
        {
            return false;
        }

        for (int x = 2; x < N; x++)
        {
            if (N % x == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        int N = 7;
        if (IsPrime(N))
        {
            Console.WriteLine(N + " is a prime number.");
        }
        else
        {
            Console.WriteLine(N + " is not a prime number.");
        }

        
        Debug.Assert(IsPrime(2) == true);
        Debug.Assert(IsPrime(3) == true);
        Debug.Assert(IsPrime(4) == false);
        Debug.Assert(IsPrime(13) == true);
        Debug.Assert(IsPrime(1) == false);
    }
}