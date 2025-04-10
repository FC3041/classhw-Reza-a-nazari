namespace CLASS;

class Program
{
    
class Student :Iperson
{
    // public static void printperson(Student s)
    // {
    //     Console.WriteLine(s.Fullname);
    // }
    // public static void printperson(Teacher s)
    // {
    //     Console.WriteLine(s.Fullname);
    // }

    public string FirstName {get;set;}

    public string LastName {get;set;}

    public string Fullname => FirstName + LastName ;

    // public string Fullname
    // {
    //     get
    //     {
    //         return FirstName + LastName ;
    //     }
    // }

}

    public static void Main(string[] args)
    {

    }

    
    #region hide.tcf
    static void Main2(string[] args)
    {
        try
        {
            int x =0 ;
            int w =5 /x ;
            //code after potentional error
        }
        catch(Exception e)
        {
            //code error handling 
            Console.WriteLine(e.Message);
            throw ;
        }

        finally
        {
            Console.WriteLine("Program closed !");
        }
    }
    #endregion
    //member variable?!
    //generic method???
}
