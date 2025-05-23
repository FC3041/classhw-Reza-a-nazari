public interface Ishape
{
    public double  Area();
    public double Perimeter();


}

public class Rectangle : Ishape
{
    public double L ;
    public double W ;
    public Rectangle(double LL , double WW)
    {
        L = LL;
        W = WW;

    }

    public double Area()
    {
        return L*W ;

    }

    public double Perimeter()
    {
        return 2*(L+W);
    }


}


public class Circle : Ishape
{

    public double Radius ;
    public double Area(double r)
    {
        
    }

    public double Perimeter()
    {
        
    }

}