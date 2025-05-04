using System.Numerics;

public class ComplexNumber
{
    public double re ;
    public double Im ;
    public ComplexNumber(double r , double i)
    {
        this.re = r ;
        this.Im = i ;
    }
    public void printcN()
    {
        Console.WriteLine($"{re} + {Im}i");

    }

    public static ComplexNumber operator+(ComplexNumber a , ComplexNumber b)
    {
        return new ComplexNumber(a.re + b.re , a.Im + b.Im);
    }

    public double this[int index]
    {
        get
        {
            if(index==0)
                return this.re ;
            else if (index == 1)
                return this.Im ;
            else
                throw new IndexOutOfRangeException();
        }
        set
        {
            if (index==0)
                this.re = value;
            else if(index==1)
                this.Im = value;
            else
                throw new IndexOutOfRangeException("index out of range!");
            
        }
    }

    // public static explicit  operator double(ComplexNumber a)
    // {
    //     return a.re ;
    // }

    public static implicit operator double(ComplexNumber a)
    {
        return a.re ;
    }

    public static implicit operator ComplexNumber(double a)
    {
        return new ComplexNumber(a,a);
    }
}