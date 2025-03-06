#include <iostream>
#include <string>
#include <cstdio>
#include <windows.h>
using namespace std;

class myfile
{
    string m_filename;
    FILE * m_filehandle;
public:
    myfile(const string& filename) : m_filename(filename)
    {
        m_filehandle = fopen(m_filename.c_str(), "a"); // باز کردن فایل در حالت افزودن (append)
        if (!m_filehandle) {
            cerr << "Error opening file: " << m_filename << endl;
        }
    }
    ~myfile()
    {
        if (m_filehandle) {
            fclose(m_filehandle);
        }
    }

    void writeln(const string &str)
    {
        if (m_filehandle) {
            fprintf(m_filehandle, "%s\n", str.c_str()); 
        } else {
            cerr << "File not open for writing." << endl;
        }
    }
};

int main()
{
    // unsigned long long l = GetTickCount64();
    // long double - 0.0987434789;
    // for(int i=0 ; i<1000000 ; i++)
    //     d = d*d
    // cout << l << endl;
    // l = GetTickCount64();
    myfile f("test.txt");
    f.writeln("textmmmm");
    return 0;
}