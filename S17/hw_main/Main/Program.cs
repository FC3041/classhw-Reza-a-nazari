namespace Main;

class Program
{
    static void Main(string[] args)
    {

        Triangle t1 = new Triangle(new Vector(1, 1),new Vector(4, 1),new Vector(2, 5));

        t1.Draw();
        Console.WriteLine($"S = {t1.GetArea()}");
    }
}
