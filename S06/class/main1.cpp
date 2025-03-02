#include <iostream>
#include <stdlib.h>

using namespace std ;

class Mylist
{
    public : 
        int m_size ;
        int m_capacity ; 
        int *m_pNums;

        Mylist(): m_size(0),m_capacity(0),m_pNums(nullptr){};

        Mylist(int size , int capacity , const int*nums);
};