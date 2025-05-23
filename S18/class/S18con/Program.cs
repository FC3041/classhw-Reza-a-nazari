namespace S18con;
// # region First desc - Null

// class Student
// {
//     public string? Firstname;
//     public Nullable <int> id ;
// }
// class Program
// {
//     static void print_student(Student? s)
//     {
//         if(s !=null)
//         {
//             Console.WriteLine($"{s.Firstname}");
//             if(s.id.HasValue)
//             {
//                 Console.WriteLine(s.id.Value);
//             }
//         }
//     }
//     static void Main1(string[] args)
//     {
//         Student? s = null ;
//         // s.Firstname = "sss";
//         print_student(s);
//         Console.WriteLine("Hello, World!");
//     }
// }
// #endregion

//interface like functionpointer with one method !

class Program
{
    delegate T fn_int_2int<T>(T  a, T b);
    static void apply<T>(T []nums1 , T []nums2 , T [] result , fn_int_2int <T> fn)
    {
        for(int i=0 ; i<nums1.Length ; i++)
        {
            result[i] = fn(nums1[i],nums2[i]);
        }
    }

    // static void apply(int []nums1 , int []nums2 , int [] result , fn_int_2int fn)
    // {
    //     for(int i=0 ; i<nums1.Length ; i++)
    //     {
    //         result[i] = fn(nums1[i],nums2[i]);
    //     }
    // }
    


    // int 

    static int add(int a , int b) => a +b;
    static int mul(int a , int b) => a*b;

    static void dodo<T>(T[] values , Action<T> a)
    {
        foreach(var v in values)
        {
            a(v);
        }
    }

    static void Main(string[] args)
    {
        Func<int , int > f ;
        Action<int>fl ;
        int[] n1 = new int[3]{1,2,3};
        int[] n2 = new int[3] {-1,-2,-3};
        int[]r = new int[3];

        apply(n1,n2,r,mul);
        for(int i=0 ; i<r.Length ; i++)
        {
            System.Console.WriteLine(r[i]);
        }
        dodo(r,Console.WriteLine);
    }
    
}

// LAMBDA CLOSURE