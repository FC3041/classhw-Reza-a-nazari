#include <iostream>
#include <math.h>
using namespace std;

class point
{
    public:
        double x ;
        double y ; 
    

};

void print_point(point p)
{
    cout << "x: " << p.x << "y :" <<p.y <<endl ;
}

double d_of_xy(point m , point q)
{
    double x_diff = m.x - q.x ; 
    double y_diff = m.y - q.y ;
    return sqrt(x_diff * x_diff + y_diff * y_diff);
}

int main() {
    int a ;
    point p1 ;

    p1.x = 4 ;
    p1.y=  6 ;

    point p2 ;

    p2.x = 5 ;
    p2.y = -2 ;

    double r = d_of_xy(p1,p2);

    cout<< r << endl;
    cout <<p1.x << endl ;  

    cout <<p1.y << endl ;  


    cout <<p2.y<<endl ; 
    
    cin>>a ;
    cout<<"a: " <<a<<endl ;
    return 0 ;
}
