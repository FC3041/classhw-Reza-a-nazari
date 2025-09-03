namespace s07;

class Program
{
    static void Main(string[] args)
    {
        // for(int i=0 ; i<1000000 ; i++)
        // {
        //     //after any process of i (like i=1 then i=2) , last memory has been deleted from your system
        //     int[] nums = new int[1000*1000];
        //     Thread.Sleep(1);
        //     //grabage collector
        // }
        static void update(int[]nums)
        {
            for(int i=0 ; i<nums.Length ; i++)
            {
                nums[i]++ ; 
            }
        }


        int x ; //in helper say : x is decelared but didn't used 
        double d ; //stack
        string s ; // refrence
        int [] num = new int[10] {1,2,3,4,5,6,7,8,9,10} ; 
        update(num) ;

        for(int i=0 ; i<num.Length ; i++)
        {
            Console.WriteLine(num[i]);
        }
    }
    
}

//ref




///////////////////////////////////
//////////////////////////////////
//////////// 3.3.2025 ///////////
////////////////////////////////
///////////////////////////////