#include <iostream>
#include <stdio.h>
#include <windows.h>
#include <string.h>


using namespace std ;



class keeptime
{
    public:
        template<typename tabe>
        unsigned long long tick(tabe amalgar)
        {
            unsigned long long first = GetTickCount();
            amalgar();
            
            unsigned long second = GetTickCount64();
            return second- first ; 
        }
};


void myfunced()
{
    for(int i = 1 ; i<10000 ; i++)
    {
        for(int j = 1 ; i<10000 ; i++)
        {
            for(int k = 1 ; k< 1000 ; k++ )
            {
                int ans = k*k*i+j ; 
            } 
        }
    }
}


int main()
{
    keeptime ticks ; 


    unsigned long long first_ans = ticks.tick(myfunced) ;


    cout<<first_ans<<endl;



    return 0 ;
}
