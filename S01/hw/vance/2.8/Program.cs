using System;

public class Program
{
    public static int ComputeSum(int N)
    {
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum = sum + i;
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        int N = 10;
        Console.WriteLine("N = {0}, ComputeSum(N) = {1}", N, ComputeSum(N));
    }
}

// vase debugger  f5 bezanid