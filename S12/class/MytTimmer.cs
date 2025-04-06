using System.Diagnostics ;

public class MyTImmer : IDisposable
{
    public string name ;
    private Stopwatch sw ;
    public MyTImmer(string nm)
    {
        name = nm ;
        sw.Start();
    }

    public void Dispose()
    {
        sw.Stop();
        Console.WriteLine($"{this.name}");
    }
    public void  printsw()
    {
       Console.WriteLine(); 
    }
}
