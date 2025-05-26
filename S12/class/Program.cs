namespace S12;

class Program
{
    public static void Mysort(student[]plist)
    {
        for(int i=0 ; i<plist.Length ; i++)
        {
            for(int j =i ; j<plist.Length ; j++)
            {
                if(plist[i].NID < plist[j].NID)
                {
                    swap(plist,i,j);
                }
            }
        }
    }

    public static void swap (student[] plist , int i , int j)
    {
        student temp = plist[i];
        plist[i] = plist[j];
        plist[j] = temp;
    }



    static void Main(string [] args)
    {
        student[] students = new student[3](
         new student("ali" , "mohammadi" , 376543),
         new student("ali2" , "mohammadi2" , 276543),
         new student("ali 3", "mohammadi3" , 176543)
        )
   
    }


    // static void Main(string[]args)
    // {
    //     student p1 = new student("ali" , "mohammadi" , 376543);
    //     student p2 = new student("ali2" , "mohammadi2" , 276543);
    //     student p3 = new student("ali 3", "mohammadi3" , 176543);
    //     List<student> student = new List<student>();
    //     student.Add(p1);
    //     student.Add(p2);
    //     student.Add(p3);
    // }

    // static void Main(string[]args)
    // {
    //     Ishape[] shape = new Ishape[](
    //         new Rectangle(2,3),
    //         new Circle(8),
    //         new Rectangle(7,5)
    //     );
    //     double Area_sum =0 ;
    //     double P_sum =0 ;
    //     for(int i=0 ; i<shape.Length ;i++)
    //     {
    //         P_sum += shape[i].Perimeter();
    //         Area_sum +=shape[i].Area();

    //     }
    //     Console.WriteLine($"{Area_sum} , {P_sum}");
    // }
    static void Main2(string[] args)
    {
        using(MyTImmer time = new MyTImmer("Add"))
        {
            int sum =0;
            
        }
    }
}
