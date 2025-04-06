public class student : IComparable
{
    public string fname ;
    public string lname ;
    public int NID ;
    public student(string f , string l , int id)
    {
        fname = f ;
        lname = l;
        NID = id ;
    }

    public int CompareTo(object? obj)
    {
        student tempt = obj as student ;
        if (tempt == null)
        {
            return 1 ;
        }
        return this.NID.CompareTo(tempt.NID);
    }

    public int Ishigher(student std)
    {
            
    }
}

