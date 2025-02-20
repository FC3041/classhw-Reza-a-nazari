#include <iostream> 
using namespace std ;
#include <string.h>
#include <stdlib.h>

class Student
{
    public : 
        int m_stdNUm ; //int = 4
        char m_Firstname[20];
        char m_Lastname[20]; // char = 1
        int m_coursespassed;
        int m_credits[40];
        double m_grades[40];
        char * m_coursenames[40]; //char * = 8
        double get_gpa()
        {
            double sumgrade = 0.0 ;
            int sumcredit = 0 ; 
            for(int i=0 ; i<m_coursespassed ; i++)
            {
                sumgrade += m_credits[i] * m_grades[i] ; 
                sumcredit += m_credits[i];

            }
            return sumgrade/sumcredit ;
        }
        
        void list_courses()
        {
            for(int i=0 ; i <m_coursespassed ; i++)
            {
                cout<<m_coursenames[i] << " : "
                    <<m_credits[i] << " : "
                    <<m_grades[i] << endl;
            }
        }
        
        void register_course(int credits ,  const char* name , double grade )
        {
           m_credits[m_coursespassed] = credits ; 
           m_grades[m_coursespassed] = grade ;
        //    char * namecopy =(char *) malloc(strlen(name)+1) ; doroste
            char * namecopy = new char[strlen(name) +1];
           strcpy(namecopy,name) ;
           m_coursenames[m_coursespassed] = namecopy ; 
           m_coursespassed ++ ;
        }
        Student(){}
};



int main()
{
    Student s ;
    s.m_coursespassed = 0 ;
    char bufc[20];
    double grade ;
    int credits ;
  
    while(true)
    {

        cout <<"course name ?" ;
        cin >> bufc ;
        if(*bufc == 'A')
            break;
        cout<<"course credits ?" ; 
        cin>> credits ;
        cout <<"course grade ?" ; 
        cin >> grade ;
        s.register_course(credits,bufc,grade) ;
    }


    s.list_courses();
    cout<<s.get_gpa() << endl;

}



//جلسه بعد کانستراکتور و دیستراکتور تمرین شود

