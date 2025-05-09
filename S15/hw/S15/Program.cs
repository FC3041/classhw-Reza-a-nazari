namespace S15;
using System.Numerics ;

class Program
{
    static T Sum_inumber<T>(T[]nums) where T:INumber<T>
    {
        T sum = T.Zero ;
        for(int i =0 ; i<nums.Length ; i++)
        {
            sum = sum + nums[i] ;
        }
        return sum ;
    }


    static void Main(string[] args)
    {
        int [] nums = {1,2,3,4,5,6,7,8,9,10};
        int my_sum = Sum_inumber<int>(nums);

        Console.WriteLine($"jam 1 ta 10 barabar 55 va jam ma barabar ba = {my_sum} " );
    }
}
