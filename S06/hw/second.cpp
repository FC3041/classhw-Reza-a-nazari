#include<iostream>

using namespace std;

class MyStr
{
    public:
    int m_size;
    int m_capacity ; 
    char* m_PChars;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }

    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }
    int len()
    {
        int count = 0 ;
        while(m_PChars[count] != '\0')
        {
            count++;
        }
        cout<<"len = "<<count<<endl;
        return count ;
    }

    void add(const MyStr& second)
    {
        if(second.m_PChars == nullptr)
            return;
        
        
        for(int j = 0; j < second.m_size; j++)
        {
            m_PChars[m_size + j] = second.m_PChars[j];
        }
        m_size = m_size + second.m_size;
        m_PChars[m_size] = '\0';
    }

    void checkSubstr(const char *mychar)
    {
        int sub_len = 0;
        while(mychar[sub_len] != '\0')
            sub_len++;

        
        if(sub_len > m_size)
        {
            cout << " reshte vojod nadarad" << endl;
            return;
        }

        int found = 0;
        for(int i = 0; i <= m_size - sub_len; i++)
        {
            found = 1;  
            for(int j = 0; j < sub_len; j++)
            {
                if(m_PChars[i + j] != mychar[j])
                {
                    found = 0;  
                    break;
                }
            }
            if(found == 1) 
            {
                cout << "Reshte vojod darad" << endl;
                return;
            }
        }
        cout << "Reshte vojodnadarad" << endl;
    }

    void printStr()
    {
        cout << m_PChars << endl;
    }
};


int main()
{
    MyStr s1;

    MyStr s2("malihe hajihosseini", 7, 12);
    s2.printStr();
    s2.checkSubstr("haji");
    s2.len();
    MyStr s4("haji", 0, 4);
    MyStr s3(" hosseini", 0, 9);  
    s4.add(s3);
    s2.printStr();   
}