#include<vector>
#include<iostream>
#include<string>
#include <stdio.h>



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

 
// int main()
// {
//     myvector v ;
//     v.add(2);
//     v.add(5);
//     cout<< v.at(0) << " " << v.at(1)<<endl; 
//     return 0 ;
// }

class myfile
{
    string m_filename ; 
    FILE*  m_filehandle ;
public :
    myfile(const string &filename)
        : m_filename(filename)
    {
        m_filehandle = fopen(m_filename.c_str(),"w") ; 
    }

    ~myfile()
    {
        fclose(m_filehandle);
    }

    void writeln(const string&str)
    {
        fprintf(m_filehandle,str.c_str());
    }
};

int main()
{
    myfile f("test.txt");
    f.writeln("test\n");
    return 0 ;
}