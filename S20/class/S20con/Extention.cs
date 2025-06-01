using System.Security.Cryptography.X509Certificates;

public static class Ext //نمیخواهیم از کلاس ،، آبجکت بسازیم پس استاتیک است
{
    public static string TitleCase(this string str)
    {
        if(str ==null)
            return str ;
        return char.ToUpper(str[0])+str.Substring(1);
    }

    public static int Number_Count(this string str) //
    {
        int  count =0  ;
        if(str==null)
            return 0 ;
        foreach(char p in str)
        {
            if (char.IsDigit(p))
            {
                count++ ;
            }
        }
        return count ;
    }
}


//TODO1
//coder //decoder --->sezar with string and write here