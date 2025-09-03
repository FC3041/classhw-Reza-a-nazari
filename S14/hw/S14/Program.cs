namespace S14;

class Program
{
    static void Main(string[] args)
    {
        Znumber num = new Znumber();

        num.x = 3.0;
        num.y = -2.0 ;

        Znumber num2 = new Znumber();

        num2.x = 3.5 ;
        num2.y = -1.0 ;
        Console.WriteLine(num.PrintNum());
        Console.WriteLine(num.Sum(num2).PrintNum());
        Console.WriteLine(num.Distance());
    }

}
