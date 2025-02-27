#include <iostream>
#include <string.h>
#include <vector>
using namespace std;


// class works
// {
//     // private:
//     // int size = 0 ;

//     // int eraser(int * arr , int vol)
//     // {
//     //     int temp1 = arr[size-1] ; 
//     //     for()

//     // }


// };



class works
{
    public:
    int capacity ; 
    works() 
    {
        capacity = 0;  
    }

    void tazmin_zarfiat(vector<int>& vec)
    {
        
        if (vec.size() == capacity)
        {
            if (capacity == 0) 
            {
                capacity = 1;  
            }
            else 
            {
                capacity = capacity * 2;  
            }
            vec.resize(capacity);  
        }
    }
    vector<int> append(vector<int>& vec, int num_morede_nazar , int index)
    {
        tazmin_zarfiat(vec);
        vector<int> newVec(vec.size() + 1);

        for (int i = 0; i < index; i++)
        {
            newVec[i] = vec[i];
        }

        newVec[index] = num_morede_nazar ; 

        for (int i = index; i < vec.size(); i++)
        {
            newVec[i + 1] = vec[i];
        }

        return newVec ; 
    }

    vector<int> pop(vector<int>& vec)
    {
        vector<int> newVec(vec.size()-1);

        for(int i=1 ; i<vec.size();i++)
        {
            newVec[i-1]=vec[i];
        }
        return newVec ; 
    }

    int at(vector<int> &vec , int index)
    {
      return vec[index];
    }



    void printf(const vector<int>& vec) 
    {
        cout << "{ ";
        for (int i = 0; i < vec.size(); i++) 
        {
            cout << vec[i];
            if (i != vec.size() - 1) 
            {
                cout << ", ";
            }
        }
        cout << " }" << endl;
    }
    void print_capacity(vector<int>& vec)
    {
        capacity = vec.capacity();
        cout << "Capacity->  " << capacity << endl;
    }

        

};


int main()
{
    works n1 ; 
    vector<int> list1 = {1,2,3,4,5,6} ;
    n1.printf(list1);
    //append
    vector<int> res1 = n1.append(list1,8,3);
    n1.printf(res1);
    n1.print_capacity(res1);
    //pop_r[0]
    vector<int> res2 = n1.pop(res1);
    n1.printf(res2);
    n1.print_capacity(res2);

    //at
    int n_th = 3;
    int res3 = n1.at(res2,n_th);
    cout<<"array["<<n_th<<"] = "<<res3<<endl;
    

    


}