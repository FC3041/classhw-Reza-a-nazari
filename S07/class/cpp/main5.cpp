#include <iostream>
using namespace std ;


// class bigobj
// {
//     char buf[1000*1000*5];
// };

// int main()
// {
//     bigobj* obj = new bigobj ;
//     cout <<"done" << endl;
// }


class bigobj
{
    char buf[1000*1000];

};
void mest(bigobj& b)
{
    
    cout<<"done test1" << endl;
}
void test(bigobj b )
{
    mest(b);
    cout<<"done test2"<<endl;
}



int main()
{
    bigobj bo ;
    test(bo);
    cout <<"done test3" << endl;
}