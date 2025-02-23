#include <iostream>
using namespace std ;

//append
//pop
//len
//sort
//max
//min

class List_functions
{
    private:
        int * mylist ;
        int list_size ;

    public : 
        List_functions(int * get_list , int size)
        {
           list_size = size ;
           mylist = new int[list_size];
           for(int i=0 ; i<size ; i++)
           {
                mylist[i] = get_list[i] ;  
           }
        }

        void min()
        {
            int a = mylist[0];
            for(int i=1 ; i<list_size ; i++)
            {
                if(a>mylist[i])
                {
                    a = mylist[i];
                }
            }
            cout<<"min : " << a <<endl;
        }
        void max()
        {
            int a = mylist[0];
            for(int i=1 ; i<list_size ; i++)
            {
                if(a<mylist[i])
                {
                    a = mylist[i];
                }
            }
            cout<<"max : " << a <<endl;
        }

        void sort()
        {
            for (int i = 0; i < list_size - 1; i++)
            {
                for (int j = 0; j < list_size - i - 1; j++)
                {
                    if (mylist[j] > mylist[j + 1])
                    {
                        
                        int temp = mylist[j];
                        mylist[j] = mylist[j + 1];
                        mylist[j + 1] = temp;
                    }
                }
            }
        }



        void append(int val)
        {
            int * new_list =new int[list_size+1];

            for (int i = 0; i < list_size; i++) 
            {
                new_list[i] = mylist[i] ;
            }
            new_list[list_size] = val;
            delete[]mylist ;
            mylist  =  new_list;
            list_size++ ; 
        }
        void pop(int andis)
        {
            int * newer_list =  new int[list_size-1];
            int i;
            int j ;
            for(i=0 , j=0 ;i<list_size ; i++)
            {
                if(i != andis)
                {
                    newer_list[j] = mylist[i];
                    j++ ;
                }
            }
            delete[]mylist ;
            mylist = newer_list ;
            list_size -- ;
        }

        void print_arr_all()
        {
            cout<<"{";
            for (int i = 0; i < list_size; i++)
            {
                cout << mylist[i];
                if (i < list_size - 1)
                {
                    cout << ", ";
                }
                
            }
            cout << "}" << endl; 
        }
        int * return_list()
        {
            return mylist ;
        }
        ~List_functions()
        {
            delete[]mylist ; 
        }
        
};

int main()
{
    int arr[] = {9,99,1,-2,333,29} ; 
    int temp_size = sizeof(arr)/sizeof(arr[0]);
    List_functions listObj(arr,temp_size);
    

    listObj.append(10);
    listObj.print_arr_all();

    listObj.pop(0);
    listObj.print_arr_all();

    listObj.max();
    listObj.min();
    listObj.sort();
    cout<<"sort shoma dost aziz : "<<endl;
    listObj.print_arr_all();

}