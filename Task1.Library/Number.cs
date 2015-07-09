using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Library
{
    public class Number
    {
        public static double FindRootByNewton(double number, int degree, double eps)
        {
            /*double n;
    cin >> n;
    const double EPS = 1E-15;//1E-15
    double x = 1;
    for (;;) 
    {
        double nx = 
        if (abs (x - nx) < EPS)  break;
        x = nx;
    }
    printf ("%.15lf", x);  */
            double x = 1;
            double xk = x - ((x - number) / (number * x));
            while (Math.Abs(x - xk) > eps)
            {
                xk = xk - ((Math.Pow(xk, degree) - number)/(number*Math.Pow(xk, degree - 1)));
                x = xk;
            }
            return x;
        }
    }
}
