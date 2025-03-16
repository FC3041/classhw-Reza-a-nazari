#include <iostream>
#include <vector>
using namespace std ;
class Student
{
    public:
        char m_name[20];
        int m_stdnum;

};

int main()
{
    vector<int> nums ; //todo1
    nums.push_back(5);
    nums.push_back(10);
    for(int i =0 ; i<nums.size();i++)
        cout<<nums[i]<<endl;
    nums.insert(nums.begin(),2);
    nums.insert(nums.end(),3);
    //taklif ==> nums.insert(nums.index(4),0);
    //taklif ==> nums.capacity
    //taklif ==> nums.clear
}

int main2()
{
    Student s ;
    s.m_name[0] = 'A';
    cout<<*s.m_name<<endl;
}