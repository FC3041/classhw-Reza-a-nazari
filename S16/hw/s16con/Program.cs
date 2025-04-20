namespace s16con;

class Program
{
    static void Print_teacher(Teacher[] cs)
    {
        foreach(var c in cs)
            Console.WriteLine(c.ToString());
    }
    static void Main(string[] args)
    {
        Teacher jadid = new Teacher("Iliya","hosseini_zade",555666,true,1613339909,360000000,20,97389343);
        Print_teacher([jadid]);
    }
}
