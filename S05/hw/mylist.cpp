#include <vector>
#include <iostream>
using namespace std ;

class mylist {
private:
   vector<int> m_nums;
    
public:

    int m_size;  
    mylist()
    {
        m_size = 0 ;
    } 

    void get_list(const vector<int>lists)
    {
        m_nums = lists ; 
        m_size = lists.size();
    }

    void append(int mynum, int index) 
    {
        m_size++;
        int h = 0;
        for(int i = 0; i < m_size; i++) 
        {
            if(i == index) 
            {
                m_nums[h] = mynum;
                h++;
                continue; 
            }
            m_nums[h] = m_nums[i];
            h++;
        }
        m_size--;
        m_nums.resize(m_size);
    }

    void erase(int index) 
    {
        m_size--;
        int k = 0;
        for(int i = 0; i < m_size; i++) {
            if(i == index)
                i++;
            m_nums[k] = m_nums[i];
            k++;
        }
        m_nums.resize(m_size);
    }
    
    void clear()
    {
        m_size =0 ;
        m_nums.resize(m_size);
    }

    int capacity() 
    {
        int cap = 1; 
        while(cap < m_size) 
        {
            cap = cap * 2; 
        }
        return cap;
    }

    void print() 
    {
        cout << "{";
        for (int i = 0; i < m_nums.size(); i++) {
            cout << m_nums[i];
            if (i < m_nums.size() - 1) {
                cout << ",";
            }
        }
        cout << "}" << endl;
    }
};

int main() 
{
    mylist list1 ;

    vector<int> temp ={1,44,2,3,4,5,6,8,9,100};

    list1.get_list(temp);

    list1.append(222,3);

    list1.erase(9);

    list1.append(931,8);

    //    =)))))

    list1.print();

    int tempsize = list1.m_size;

    cout<<"capacity="<<list1.capacity()<<endl;

    cout<<"fazaye baghimande ="<<list1.capacity() - tempsize  <<endl;

    list1.clear();

    cout<<"capacity bad az clear="<<list1.capacity()<<endl;

}


