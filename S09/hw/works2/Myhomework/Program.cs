namespace Myhomework;
using System.IO ;

public class Student
{
    public string name ;
    public  long std_id ;
    public long national_id ;
    public int age ;
    public string gender ;
    public bool active ;

}
public class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Tedad danshjohaye khod ra vared konid\t");
        int count = Convert.ToInt32(Console.ReadLine());
        Student[] std  = new Student[count];
        for(int i = 0 ; i<count ; i++)
        {
            Student std_n = new Student() ;
            Console.WriteLine("Name  :  ");
            std_n.name = Console.ReadLine() ;

            Console.WriteLine("shomare danshjoee :      ");
            std_n.std_id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("National id  :      ") ;
            std_n.national_id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Age ?  :       ");
            std_n.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" jensiat ? :       ");
            std_n.gender = Console.ReadLine();

            Console.WriteLine("sabt naam shode ya kheir ? : (true |||| false)   ");
            std_n.active = Convert.ToBoolean(Console.ReadLine());


            std[i] = std_n ; 
        }
        // for(int j =0 ; j<std.Length ; j++)
        // {
        //     Console.WriteLine(std[j]);
        // }
        string esmtxt = "names.txt";
        File.WriteAllText(esmtxt, string.Empty);
        for(int k =0 ; k<std.Length ; k++)
        {
            Console.WriteLine(std[k].name);
            Console.WriteLine(std[k].std_id);
            Console.WriteLine(std[k].national_id);
            Console.WriteLine(std[k].age);
            Console.WriteLine(std[k].gender);
            Console.WriteLine(std[k].active);
            Console.WriteLine();
            File.AppendAllText(esmtxt , std[k].name + "\n");
            File.AppendAllText(esmtxt , Convert.ToString(std[k].std_id) + "\n");
            File.AppendAllText(esmtxt , Convert.ToString(std[k].national_id) + "\n" );
            File.AppendAllText(esmtxt , Convert.ToString(std[k].age) + "\n" );
            File.AppendAllText(esmtxt , std[k].gender + "\n" );
            File.AppendAllText(esmtxt , Convert.ToString(std[k].active) + "\n" );
            File.AppendAllText(esmtxt, "\n");
        }


    }    
}
