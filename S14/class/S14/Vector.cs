using System.Numerics;

public class MyVector : IEquatable<Vector>
{
    // public MyVector(int x , int y)
    // {
    //     this.x = X;
    //     this.y = Y ;

    // }
    // public static  MyVector Parse(string s ) 
    // {
    //     string [] tokens = s.Split(",");
    //     return new MyVector (int.Parse(tokens[0],int Parse(tokens[1])));
    // }
    public int X {get ; set ;}
    
    public int Y {get ; set ;}
    public double Magnitude => Math.Sqrt(X*X +  Y*Y);
    public MyVector Add(MyVector v) => new MyVector(X+v.X , Y + v.Y);


}       