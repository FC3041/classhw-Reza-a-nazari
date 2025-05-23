#include <iostream>
using namespace std ;

class Date
{
    int day ;
    int month ;
    int year ;
};


class Person
{
    int m_NID ; //کدملی
    char m_fname[20]; 
    char m_lname[20];
    Date m_BD ;
    
    public :
        Person(const char* fname , const char* lname , int id , Date bd)
        {
            m_BD = bd ;
            m_NID = id ;
            int i ;
            for(i=0 ; i<sizeof(m_fname) && fname[i]!='\0' ; i++)
            {
                m_fname[i] = fname[i] ;
            }
            m_fname[i] = '\0';
            for(i=0 ; i<sizeof(m_lname) && lname[i]!='\0' ; i++)
            {
                m_lname[i] = lname[i] ;
            }
            m_lname[i] = '\0';

        }

        void print_person()
        {
            cout << m_fname << endl;

            cout << m_lname << endl;
        }
};


int main()
{
    Date d ;
    Person p1("ali","hosseini",121322,d);

    p1.print_person();
}


//double distance(const &c1) const
//.
//.
//.
// c1.distance(c2) ----->   const aval yani c2 saabet va - const avali yani c1 sabet