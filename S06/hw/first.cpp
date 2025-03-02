#include<iostream>
#include<stdlib.h>

using namespace std;

class MyList
{
    public:
        int m_size;
        int m_capacity;
        int* m_pNums;

        MyList():m_size(0),m_capacity(0),m_pNums(nullptr){};

        MyList(int size, int capacity , const int* nums)
        :m_size(size), m_capacity(capacity)
        {
            m_pNums = (int *)malloc(sizeof(int)*capacity);
            for (int i=0; i<m_size;i++)
            {
                m_pNums[i] = nums[i];
            }
        }

        void print_list()
        {
            cout << "size:" << m_size << " capacity:" << m_capacity << endl;
            for(int i=0;i<m_size;i++)
            {
                cout << m_pNums[i] << ",";
            }
            cout << endl;

        }


        void sort()
        {
            for (int i = 0; i < m_size - 1; i++)
            {
                for (int j = 0; j < m_size - i - 1; j++)
                {
                    if (m_pNums[j] > m_pNums[j + 1])
                    {
                        int temp = m_pNums[j];
                        m_pNums[j] = m_pNums[j + 1];
                        m_pNums[j + 1] = temp;
                    }
                }
            }
        }

    private:
        void resize(int newsize)
        {
            int* newNums = (int*)malloc(sizeof(int)*(newsize));
            for(int i=0; i<m_size;i++)
            {
                newNums[i] = m_pNums[i];
            }
            free(m_pNums);
            m_pNums = newNums;
            m_capacity = newsize;

        }
};

int main()
{
    MyList l1;

    int nums[5] = {9,33,1,3,10};
    MyList l2(5, 10, nums);
    l2.sort();
    l2.print_list();

    return 0;
}