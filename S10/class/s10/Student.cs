public class Student: IDisposable
{
    private string name ;
    public Student(string name)
    {
        this.name = name;
        register(name);

    }

    
    #region hide


    ~Student()
    {
        Console.WriteLine($"{this.name} is deallocated!");
    }
    private void register(string name)
    {
        Console.WriteLine($"{name} is registered");
    }


    public void Dispose()
    {
        System.Console.WriteLine($"{this.name} is Unregistered"); //this.name ===> private name
    }



    #endregion
}