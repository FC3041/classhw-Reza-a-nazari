namespace S8
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");
        }
    }

    // public class Calculator
    // {
    //     public int Add(int a, int b)
    //     {
    //         return a + b;
    //     }
    // }


    public class just_rev_string
    {
        public static string reversed(string jomle)
        {
            int len = jomle.Length ; 
            String res1 = "";


            for(int i = len - 1; i >= 0; i--)
            {
                res1 +=  jomle[i];
            }

            return res1 ; 
        }

        public static string rev_word_to_end(string jomle2)
        {
            string[] words = jomle2.Split(' ');
            string ans = "";
            for(int i=words.Length-1 ; i>=0 ; i--)
            {
                if( i  != words.Length-1)
                {
                    ans+= " " ; 

                } 
                ans +=words[i];
            }
            return ans ; 
            
        }
    }
}
