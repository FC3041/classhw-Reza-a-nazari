#include<vector>
#include<iostream>
#include<string>
using namespace std;

class myvector
{
    public:
    myvector(int capacity=10)
        : m_capacity(capacity)
        , m_buffer(new int[capacity])
        , m_size(0) 
    {

    }
    ~myvector()
    {
       delete [] this->m_buffer ; 
       this ->m_capacity = 0 ; 
    }

    void add(int e)
    {
        m_buffer[m_size] = e ; 
        m_size++ ; 
    }

    int at(int index)
    {
        return m_buffer[index];
    }

    private : 
        int m_capacity ;
        int m_size ; 
        int * m_buffer;

};


int main()
{
    myvector v ;
    v.add(2);
    v.add(5);
    cout<< v.at(0) << " " << v.at(1)<<endl; 
    return 0 ;
}