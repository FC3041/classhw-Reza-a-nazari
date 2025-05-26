class citizen 
{
    public string firstname{get;set;} 
    public string lastname{get;set;}

    public int nat_id{get;set;}
    public bool ismale{get;set;}

    public int Postalcode{get;set;} =0 ;


    public citizen(string fname , string lname , int id , bool IS_male,int postcode)
    {
        this.firstname = fname ;
        this.lastname = lname ;
        this.nat_id = id ;
        this.ismale = IS_male ;
        this.Postalcode = postcode ;
    }
    // public citizen(){}

    // public citizen(string fname , string lname , int id , bool  is_m ): this(fname,lname,id,is_m , 0);
}

class Student : citizen
{
    public int  Stdid{get;set;}
    public string Major{get;set;}
    public bool Ispaying{get;set;}


    public Student(string fname , string lname , int id , string major , int stdid , bool ispaying) : base(fname,lname,id,false)
    {
        this.Ispaying = ispaying ;
        this.Major = major ;
        this.Stdid = stdid ;
    }



}


// public class Teacher : citizen
// {
//     //TODO1 salary
//     //TODO2 Rating 
//     //TODO3 EmployeeId
// }




class GradStudent : Student
{
    public string Minor {get;set;}
    public string thesistitle{get;set;}
    public GradStudent(
        string fname , string lname ,  
        int id , string major , int stdid ,
        bool ispay ,  string minor , string thesistitle
    ):base(fname,lname,id,major,stdid , ispay);
}