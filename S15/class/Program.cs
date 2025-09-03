using System.Numerics;
using System.Runtime.CompilerServices;

namespace Program;

class Program
{
    static void swap<T>(ref T a ,ref  T b)
    {
        T tmp = a ;
        a = b ;
        b = tmp ;
    }

    static T max<T>(T a , T b)
        where T : IComparable<T>
    {
        if(a.CompareTo(b) < 0)
            return b ;
        return a ;
    }
    static void Main(string[] args)
    {
        int a = 5 ;
        int b = 6 ;
        string sa ="ali" ;
        string sz = "zalie";
        Student ssa = null , ssb = null ;
        Student c = max<Student>(ssa,ssb);

        int [] nums = {1,2,3,5};
        int sum = sum<int>(nums) ;
        List<int> nnn = new List<int>(); //Add
        Stack <int> numsstack = new Stack<int>(); // Push - Pop
        int [] nums1 = new int[] {1,23,4};
        Queue<int> qhums = new Queue<int>();

    }
    //TODO Sum of INUmber
    // static T sum<T>(T a , T b)
    //      where T : INumber<T>  //Tamrin -> in ro ba list bezan
    // {
    //     return (a+b) ;
    // }

    static void PrintItems<T>(IEnumerable<T> items)
    {
        foreach(T i in items)
        {
            Console.WriteLine(i);

        }
    }

    static T suum<T>(IEnumerable<T> items)  where T:INumber<T> //chandta chiz az yek noe
    {
        T sum  = T.Zero ;
        foreach(T j in items)
        {
            sum = sum+ j ;
        }
        return sum ;
    }

    static void PrintItemsMe<T>(IEnumerable<T>  items)
    {
        IEnumerator<T> eor = items.GetEnumerator();
        while(eor.MoveNext())
        {
            System.Console.WriteLine(eor.Current);
        }

    }


    static T sum<T>(T[] nums) where T:INumber<T>
    {
        T sum = T.Zero ;
        for(int i=0 ; i<nums.Length ;i ++)
        {
            sum = sum + nums[i] ;
        }
        return sum ;
    }
    // IEnumerable<int> ax = new List<int>();

}
