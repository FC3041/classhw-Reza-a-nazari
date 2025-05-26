using System.Numerics;

namespace S20con;


public class Mytuple<T1,T2>
{
    public T1 Item1 ;
    public T2 Item2 ;

    public Mytuple(T1 item1 , T2 item2)
    {
        this.Item1 = item1;
        this.Item2 = item2 ;
    }


}


// public class IntTuple
// {
//     public int Item1;
//     public int item2 ;

//     public IntTuple(int t1 , int t2)
//     {

//     }
// }
class Program
{
    public static (int , int , double) AnalyzeList(List<int> numbers)
    {
        if(numbers == null || numbers.Count==0)
            throw new Exception("List must not be empty");
        int min = numbers.Min();
        int max = numbers.Max();
        double avg = numbers.Average();
        avg = Math.Round(avg,2);

        return (min,max,avg);
    }

    static void Main(string[]args)
    {
        Tuple<string,int> t1 = new Tuple<string, int>("ali",12);
        System.Console.WriteLine(t1.Item1+t1.Item2);

        var t2 = new Tuple<string,int,int>("zoha",12,1334);

        System.Console.WriteLine($"{t2.Item1},{t2.Item2},{t2.Item3}");

        var t3 = Tuple.Create<string,int>("hoda",22);

    }

    static void Main3(string[]args)
    {
        string name = "computer";
        string nam2 = name.TitleCase(); /////////////////////////substring az n+1 chap ya minevise//////////////
        Console.WriteLine(nam2);
        string text ="lkjhfd8764???";
        Console.WriteLine(text.Number_Count());

    }

    static void Main2(string[]args)
    {
        int x =5  ;
        double y = 6.8 ;

        y = x ;/////////////////////////////////////////// //implicit
        x = (int)y ;//////////////////// //explicit

        ComplexNumber c1 = new ComplexNumber(2,6);
        ComplexNumber c2 = new ComplexNumber(1,9);

        y = c1 ; // implicit az yek moteghayer be class
        c2 = y ; // explicit az yek class be moteghayer

    }

    static void Main1(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


//TODO2
//Tuple ------|
//            
//min max average