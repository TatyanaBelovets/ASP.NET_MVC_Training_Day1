using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Library
{
    public static class Number
    {
        public static double FindRootByNewton(double number, int degree, double eps)
        {
            double x = 1;
            double xk = 2 - (x / number);
            while (Math.Abs(x - xk) > eps)
            {
                x = xk;
                xk = xk - ((Math.Pow(xk, degree) - number)/(number*Math.Pow(xk, degree - 1)));
                
            }
            return x;
        }
    }
}
