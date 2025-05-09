#include <iostream>
#include <string.h>
using namespace std ;

class student
{
    public:
        char m_firstname[30];
        char m_lastname[30];
        int m_student_id ;
        int m_courses_passed ; 
        int m_credits[30] ;
        int m_grades[30];
        char * m_courses_name[40];
        
        student(int student_id , const char* firstname , const char* lastname )
        {
            m_student_id = student_id ;
            strncpy(m_firstname , firstname , 19);
            m_firstname[19] = '\0';
            strncpy(m_lastname , lastname , 19 ) ; 
            m_lastname[19]= '\0' ;
            m_courses_passed = 0 ;
            for(int i = 0 ; i<40 ; i++)
            {
                m_courses_name[i] = nullptr ;
            }


        }

        ~student()
        {
            for(int i=0 ; i<m_courses_passed ; i++)
            {
                delete[] m_courses_name[i] ;

                cout<<"the courses shoma : "<< m_courses_name[i] <<" az hafeze delete shod"<<endl ; 
            }
        }

        double get_avg()
        {
            double sumgrade = 0 ;
            double sumcredit = 0 ;
            for(int i =0 ; i<m_courses_passed ; i++)
            {
                sumgrade += m_credits[i] * m_grades[i] ;
                sumcredit += m_credits[i];

            }
            return sumgrade/sumcredit ; 
        }

        void list_courses()
        {
            for(int i=0 ; i<m_courses_passed ; i++)
            {
                cout << m_courses_name[i] << ": "
                     << m_credits[i] << " : "
                     <<m_grades[i]<< endl ; 
            }
        }

        void register_course(int credits , const char* name , double grade)
        {   
            m_credits[m_courses_passed]= credits ; 
            m_grades[m_courses_passed] = grade ; 
            char * namecopy = new char[strlen(name)+1];
            strcpy(namecopy,name);
            m_courses_name[m_courses_passed] = namecopy ;
            m_courses_passed ++ ;
        }

} ; 


int main()
{
    student s(3423, "asdf", "lasdkfj");
    student* s2 = new student(3423, "asdf", "lasdkfj");
    student* s3 = &s;
    int * pn = new int[10];
    s.m_courses_passed = 0;
    char bufc[20];
    double grade;
    int credits;
    while(true)
    {
        cout << "course name?" ;
        cin >> bufc ;
        if (*bufc == 'A')
            break;
        cout << "course credits?" ;
        cin >> credits ;
        cout << "course grade?" ;
        cin >> grade ;
        s.register_course(credits, bufc, grade);
    }
    s.list_courses();
    cout << s.get_avg() << endl;
    return 0;
}