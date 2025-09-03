using System.Runtime.CompilerServices;

interface IShape
{
    // string Name;    
}

class Vector{ 
    public Vector(int x, int y) {this.X = x; this.Y = y;}
    public int X {get; set;} 
    public int Y {get; set;}
    public static Vector operator+(Vector v1, Vector v2)
    {
        v1.X += v2.X;
        v1.Y += v2.Y;
        return v1;
    }
    public override string ToString() => $"[{X},{Y}]";
    public Vector Clone()
    {
        return new Vector(this.X, this.Y);
    }

}

abstract class Shape
{
    private string Name;
    protected Vector[] points;
    public void Move(Vector d)
    {
        for(int i=0; i<points.Length; i++)
            points[i] += d;
    }

    public void Draw()
    {
        for(int i=1; i<points.Length; i++)
            System.Console.WriteLine($"line({points[i-1]} => {points[i]})");
    }

    public abstract double GetArea();
}


class Triangle : Shape
{

    public Triangle(Vector a , Vector b , Vector c)
    {
        this.points = new Vector[3]{a.Clone() , b.Clone() , c.Clone()};
    }

    public Triangle(Vector firs_start , int len , int h )
    {
        this.points = new Vector[3]{firs_start.Clone() , new Vector(firs_start.X+len , firs_start.Y) , new Vector(firs_start.X ,firs_start.Y + len )};
    }


    public double d (Vector n1 , Vector n2)
    {
        return Math.Sqrt(Math.Pow(n1.X - n2.X , 2) + Math.Pow(n1.Y-n2.Y , 2 ));
    }


    public override double GetArea() 
    {
        double a = d(points[0], points[1]);
        double b = d(points[1], points[2]);
        double c = d(points[2], points[0]);
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

 
}