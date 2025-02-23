#include <iostream>
#include <stdlib.h>
using namespace std ;

class MyList
{
    public :
        int m_size ; 
        int * m_pnums ; 
        MyList(int size , int * nums )
        {
            m_pnums = (int * )malloc((sizeof(int)*size )+1);
            int i ;
            for(int i=0 ; i<m_size ; i++)
            {
                m_pnums[i] = nums[i];
            }
        }

        void append(int x)
        {
            resize(m_size +1);
            m_pnums[m_size-1] = x ;
        }
    private : 
    void resize(int newsize)
    {
        int * newmem = (int * )malloc(sizeof(int)*newsize);
        int i=0 ;
        for(i=0 ; i<m_size;i++)
        {
            newmem [i] = m_pnums[i];
        }
        free(m_pnums);
        m_size = newsize ;
        m_pnums= newmem  ;
    }
};

int main()
{
    int nums[5]={1,2,3,4,5};
    MyList m(5,nums);
    m.append(14);
    // cout<<newer<<endl;
}