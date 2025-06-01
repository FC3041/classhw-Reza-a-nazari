#include <stdio.h>

typedef int (*_fnp_2int_v)(int a , int b);

void apply(int * nums1 , int * nums2 , int *result , int len ,_fnp_2int_v)
{
    for(int i=0 ; i<len ; i++)
    {
        result[i] = fn(nums1[1],nums2[i]);
    }
}
int add(int a , int b ){return a+b};

int diff(int a , int b){return a-b};

int mul(int a , int b){return a*b};
int divide(int a , int b){return a/b};

int main()
{
    int nums[3] = {1,2,3};
    int nums2[3] = {-1,-2,-3};
    int num[3];

    apply(nums1,nums2,3,mul);
    
    return 0 ;

}