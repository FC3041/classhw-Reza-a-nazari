using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace E3;
/// <summary> passed
/// Q0
/// </summary>

public class Animal
{
    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }
}
public class Dog : Animal
{
    public override string MakeSound()
    {
        return "Woof";
    }
}
/// <summary> passed
/// Q1
/// </summary>
public class MyPointType1
{
    public int X { get; set; }
    public int Y { get; set; }

}

public struct MyPointType2
{
    public int X { get; set; }
    public int Y { get; set; }
}

// / <summary>
// / Q2
// / </summary>

// public class Product
// {
//     public string Name { get; set; }
//     public int Price { get; set; }
// }
// public class Comparer<T>:IComparable<T>
// {
//     public T A{ get; set; }
//     public T B{ get; set; }

//     public Comparer(T a , T b)
//     {
//         this.A = a;
//         this.B = b;
//     }

//     public T CompareTo(T other)
//     {
//         if(other>)
//             return 1; 
//     }

//     public T GetLarger()
//     {
//         return ;
//     }

//     int IComparable<T>.CompareTo(T? other)
//     {
//         throw new NotImplementedException();
//     }
// }



/// <summary> passed
/// Q3
/// </summary>

public class ResourceManager : IDisposable
{
    public bool IsDisposed;

    public void Dispose()
    {
        IsDisposed = true;
    }
}




/// <summary> passed
/// Q12
/// </summary>

public class SafeCounter
{
    public int Count;
    public Stopwatch sw;

    public void Increment()
    {
        Interlocked.Increment(ref Count);
    }
}

/// <summary> 
/// Q4 & Q5
/// </summary>
// public class Sale
// {
//     public string Category { get; set; }

//     public int Amount;
// }



// public class LinqProblems
// {
//     // public static double GetTotalAmountByCategory(List<Sale> sales)
//     // {
//     //     return 1.0;
//     // }
//     public static List<int> FilterAndDouble(List<int> numbers)
//     {
//         List<int> temp = new List<int> { };
//         foreach (var a in numbers)
//         {
//             int t1 = 0;
//             if (a % 2 == 0 & a > 5)
//             {
//                 t1 = a * 2;
//                 temp.Append(t1);
//             }

//         }
//         return temp;
//     }
// }

// ------

// public class DelegateProblems
// {
//     public string StringOperation { get; set; }



//     public static string ToUpper(string input)
//     {
//         return input.ToUpper();
//     }

//     public static string ToLower(string input)
//     {
//         return input.ToLower();
//     }


//     public static string ProcessString(string input, DelegateProblems work)
//     {
//         if (work == )
//         {
//             return input.ToUpper();
//         }
//         else
//         {
//             return input.ToLower();
//         }
//     }

/// <summary> passed
/// Q13
/// </summary>

public class DataService
{
    public async Task<string> FetchDataAsync(string s)
    {
        await Task.Delay(2);
        return "Data for user-123";
    }
}





// /// <summary> 
// /// Q6
// /// </summary>


// public class Money : IEquatable<T>
// {
//     public int v1;
//     public string v2;

//     public int Amount;

//     public Money(int v1, string v2)
//     {
//         this.v1 = v1;
//         this.v2 = v2;
//     }

//     public bool Equals(T? other)
//     {
//         if()
//     }

//     public static Money operator +(Money a, Money b)
//     {
//         if (a.v2 == b.v2)
//             return new Money(a.Amount + b.Amount, a.v2);
//         else
//         {
//             throw new Exception();
//         }
//     }

// public static bool operator ==(Money a, Money b)
// {
//     if (a.Amount == b.Amount)
//     {
//         return true;
//     }
//     else
//     {
//         throw new Exception();
//     }
// }

// public static bool operator !=(Money a, Money b)
// {
//     if (a.Amount != b.Amount)
//     {
//         return a != b;
//     }
//     else
//     {
//         throw new Exception();
//     }
// }
// }

// public class T
// {
// }




// /// <summary> 
// /// Q8
// /// </summary>

// public class LambdaProblems
// {
//     public static Func<string, int> GetStringLengthCalculator() => 
// }



// public class Closures
// {
//     public static string CreateCounter()
//     {

//     }
// }



// public class Closures
// {
//     public static Func<int> CreateCounter()
//     {
//         Task.Run()
//     }

// }



// public class Publisher
// {

// }


// public class Subscriber
// {

// }