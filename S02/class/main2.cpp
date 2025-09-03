#include <iostream>
#include <cmath>  
using namespace std;

class point
{
    public: // global in python
        double x;
        double y;

        double print_distance(point w)
        {
            double dis = sqrt((x - w.x) * (x - w.x) + (y - w.y) * (y - w.y));
            return dis;
        }

        point(double w, double b)
        {
            x = w;  
            y = b;  
        }

        point(const point &q)
        {
            x = q.x;
            y = q.y;
        }

        void print_point()
        {
            cout << "x: " << x << ", y: " << y << endl;
        }

        ~point() 
        {
            cout << "X in d"<<x << " , y in  d" << y << endl ; 
        }
};

// تابع کمکی برای محاسبه فاصله بین دو نقطه
double d_of_xy(point m, point q)
{
    double x_diff = m.x - q.x; 
    double y_diff = m.y - q.y;
    double dis = sqrt(x_diff * x_diff + y_diff * y_diff);
    return dis;
}



int main() // constructo  and distructor 
{
    point p1(1,1);
    int c =5 ;
    if(c>3)
    {
            point p2(2,2);
    }
    else
    {
        point p3(3,3);
    }
}



int main1() {
    point p1(4, 6);
    point p2(5, -2);

    // استفاده از سازنده کپی
    point p3(p2);
    
    // چاپ مقدار p3
    p3.print_point();  // ✅ اصلاح شد

    // محاسبه فاصله با تابع d_of_xy
    double r = d_of_xy(p1, p2);
    cout << "Distance (d_of_xy): " << r << endl;

    // چاپ مقادیر نقاط p1 و p2
    p1.print_point();
    p2.print_point();

    // استفاده از متد print_distance
    double b = p1.print_distance(p2);
    cout << "mk is: " << b << endl;

    return 0;
}
