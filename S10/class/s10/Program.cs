using System.Diagnostics;
using System.Text;

namespace s10;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // string[] lines = File.ReadAllLines("test.txt");
//         // File.WriteAllLines("test2.txt",lines);
//         if(args.Length !=1)
//         {
//             System.Console.WriteLine("usage : Program <input_FILE>");
//             return ;
//         }
//         StreamReader reader = new StreamReader(args[0]);
//         string line ;
//         int line_count =0 ;
//         int charecter_count = 0 ;
//         int word_count = 0 ;


//         while(null != (line = reader.ReadLine()))
//         {
//             line_count++ ;
//             foreach(string s in line.Split(' ',StringSplitOptions.RemoveEmptyEntries))
//             {
//                 word_count ++ ;
//                 charecter_count += line.Length ;
//                 if(word_count > 10 )
//                 {
//                     reader.Dispose();
//                     return ; 
//                 }
//             }
//         }
//         System.Console.WriteLine($"{line_count} {word_count} {charecter_count}");
//         reader.Dispose();
//     }
// }





class Program
{
    static void Main(string[]args)
    {
        if(args.Length==0)
        {
            using Student s  = new Student("hadi");
            Console.WriteLine("in block ");
        }
        System.Console.WriteLine("end program");
    }



    #region hide
    static void Main222222222222222(string[]args)
    {
        StringBuilder sb = new StringBuilder();
        using(StringWriter sw = new StringWriter(sb))
        {
            sw.WriteLine("test");
        }
        Console.WriteLine(sb.ToString());
    }

        
    static void Main_nemidonam_chandom(string[]args)
    {
        StringWriter writer = new StringWriter();
        StringBuilder sb = new StringBuilder();

        Stopwatch sw = new Stopwatch();
        sw.Start();

        for(int i=0 ; i<50000 ; i++)
        {
            sb.Append(i.ToString());
            sb.Append(',');            
        }
        Console.WriteLine(sb.ToString().Length);
        sw.Stop();
        Console.WriteLine(sw.Elapsed.ToString());

    }
    static void Main3(string[] args)
    {
        StringWriter writer = new StringWriter();
        string s = "" ;
        Stopwatch sw = new Stopwatch();
        sw.Start();

        for(int i=0 ; i<50000 ; i++)
        {
            s+= i.ToString() + ",";
            
        }
        Console.WriteLine(s.Length);
        sw.Stop();
        Console.WriteLine(sw.Elapsed.ToString());

    }
    static void Main2(string[] args)
    {
        // string[] lines = File.ReadAllLines("test.txt");
        // File.WriteAllLines("test2.txt",lines);
        if(args.Length>2 || args.Length<1)
        {
            System.Console.WriteLine("usage : Program <input_FILE>");
            return ;
        }
        string outfile = null  ;
        if(args.Length>1)
        {
            outfile = args[1] ;
        }

        int line_count =0 ;
        int charecter_count = 0 ;
        int word_count = 0 ;
        using (StreamReader reader = new StreamReader(args[0]))
        {
            string line ;
            while(null != (line = reader.ReadLine()))
            {
                line_count++ ;
                foreach(string s in line.Split(' ',StringSplitOptions.RemoveEmptyEntries))
                {
                    word_count ++ ;
                    charecter_count += s.Length;
                }
            }
        }
        string outstr = $"{line_count} {word_count} {charecter_count}" ; 
        if(outfile != null)
        {
            using (StreamWriter writer  = new StreamWriter(outfile))
            {
                writer.WriteLine(outstr);
            }
        }
        else{
            System.Console.WriteLine(outstr);
        }
        System.Console.WriteLine($"{line_count} {word_count} {charecter_count}");
        
    }
    #endregion
}