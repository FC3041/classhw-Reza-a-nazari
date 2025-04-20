class Citizen
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int NationalId {get; set;}
    public bool IsMale {get; set;}

    public int PostalCode {get; set;} = 0;

    public Citizen(string fname, string lname, 
                  int id, bool isMale, int postalCode)
    {
        this.FirstName = fname;
        this.LastName = lname;
        this.NationalId = id;
        this.IsMale = isMale;
        this.PostalCode = postalCode;
    
    }

    public Citizen(string fname, string lname, int id, 
                   bool isMale)
        : this(fname, lname, id, isMale, 0)
    {
    }

    public override string ToString()
    {
        return $"{base.ToString()}({this.FirstName},{this.LastName})";
    }
}

class Teacher: Citizen
{
    public long Salary{get;set;}
    public double Rating{get;set;}
    public int EmployeeId{get;set;}

    public Teacher(string fname, string lname, int id, bool isMale, int postalCode,long dar_amad,double rat , int ID) : base(fname, lname, id, isMale, postalCode)
    {
        this.Salary = dar_amad ;
        this.EmployeeId = ID ;
        if(rat>=0 && rat<=10)
        {
            this.Rating = rat ;
        }
        else
        {
            Console.WriteLine("///////////////////////////////////////////////////");
            Console.WriteLine(" dadash az 0 ta 10 bego");
            Console.WriteLine("///////////////////////////////////////////////////");

            throw new InvalidDataException("");
        }


    }

    public override string ToString()
    {
        return $"///{base.ToString()} ////va dar amad ishan {this.Salary}/// va {this.EmployeeId} Id ishan mibasad/// va {this.Rating} emtizaeshan az 10 ast .";
    }

}

