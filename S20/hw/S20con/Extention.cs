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


    public static string Sezar(this string str)
    {
        string res ="";
        foreach(char c in str)
        {
            if(char.IsLetter(c))
            {
                char basechar ;

                if(char.IsUpper(c))
                {
                    basechar = 'A';
                }
                else
                {
                    basechar = 'a';
                }

                char shifted = (char)(((c - basechar + 3) % 26 + 26) % 26 + basechar); //سلام به آقای ثابت
                                                                                       // این فرمول از سایت GeekforGeeks است
                res +=shifted;
            }
            else
            {
                res +=c ;
            }
        }        
        return res ;

        
    }
}


//TODO1
//coder //decoder --->sezar with string and write here