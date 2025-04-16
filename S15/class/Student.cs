class Student : IComparable<Student>
{
    public static bool operator < (Student a , Student b) =>a.compareTo(b) <0 ;
    public static bool operator > (Student a , Student b) =>!(a<b);

    public static Student[] operator + (Student a , double d)
    {

    }
    
    public double akhlagh{get;set;}
    public int compareTo
    {
        if(other !=null)
    }
}