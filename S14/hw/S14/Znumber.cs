using S14;

class Znumber :IZnumber
{
    public double x {get;set;}
    public double y {get;set;}


    public string PrintNum()
    {
        string alamat ;
        if(y>=0)
        {
            alamat = "+";
        }
        else
        {
            alamat = "";
        }
        return $"{x}i{alamat}{y}";
    }

    public double Distance()
    {
        double a = Math.Sqrt(x*x + y*y);
        return a ;
    }

    public  IZnumber Sum(IZnumber other )
    {
        return new Znumber { x = this.x + other.x, y = this.y + other.y };
    }

    public IZnumber Minus(IZnumber other)
    {
        return new Znumber { x = this.x - other.x, y = this.y - other.y };
    }

}