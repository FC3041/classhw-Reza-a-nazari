#include <iostream>

#include <math.h>

#include <cmath>

using namespace std ;


class dire 
{

    private:
        double x,y ;


    public :

        double distance_noghte(double m , double n)
        {
            return sqrt((x-m)*(x-m) + (y-n)*(y-n));

        }

        double distance(dire &two)
        {
            return sqrt((x-two.x)*(x-two.x) + (y-two.y)*(y-two.y));
        }
        void point(double x_val , double y_val)
        {
            x = x_val ; 
            y = y_val ;
        }
        double masahat(double r)
        {
            return M_PI* (r*r) ; 
        }
        double mohit(double r)
        {
            return 2*M_PI*(r); 
        } 
        void print_point()
        {
            cout <<"Markaz dayereh hast: (" << x << "," << y<< ")"<<endl ;
        }
        
};


int main()
{

    double x_center1 ;
    double y_center1 ;
    
    double x_center2 ;
    double y_center2 ;

    double m;
    double n;
    
    double shoae_dire1 ;
    cout<<"markaz 1 ra vared konid : (x1,y1)---> x1 y1 ";
    cin>> x_center1 >> y_center1 ; 

    cout<<"markaz 2 ra vared konid : (x2,y2)---> x2 y2 ";
    cin>> x_center2 >> y_center2 ; 
    
    cout<<"Mokhtasat noghte  ra vared konid : (m,n)---> m n ";
    cin>> m >> n ;  

    
    cout<<"shoa ra vared konid : R ";
    cin >> shoae_dire1 ; 


    dire d ;
    d.point(x_center1 , y_center1);

    d.print_point() ;


    double result = d.masahat(shoae_dire1);

    cout << "masahat ba shoae "<<shoae_dire1<<"barabar ast ba  :  "<<result<<endl ;



    double result2 = d.mohit(shoae_dire1);

    cout <<"mohit barabar ba : " << result2 << endl ;


    dire d1 ;
    dire d2 ;

    d1.point(x_center1,y_center1);
    d2.point(x_center2,y_center2);


    double result3 = d1.distance(d2);

    cout<<" fasele hast : " << result3 <<endl;


    double result4 = d1.distance_noghte(m,n);

    cout<<"fasele noghte ("<<m<<" , "<<n<<") az markaz circle yek : "   << result4 <<endl ;

    if(result4 > shoae_dire1)
    {
        cout <<"noghte mad nazar shoma yani("<<m<<","<<n<<") -----BiROn dayere ast-----"<<endl ; 
    }
    else if (result4 = shoae_dire1)
    {
        cout <<"noghte mad nazar shoma yani("<<m<<","<<n<<") -----Roy dayere ast-----"<<endl ;
    }
    else
    {
        cout <<"noghte mad nazar shoma yani("<<m<<","<<n<<") -----Dakhel dayere ast-----"<<endl ;
    }
    

    return 0 ;

}