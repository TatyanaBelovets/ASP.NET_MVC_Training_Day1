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
            if (number < 0 && degree % 2 == 0)
            {
                throw new ArgumentException("Root of even degree for negative numbers is undefined");
            }

            double x = 1;
            double xk = 2 - (x / number);
            while (Math.Abs(x - xk) > eps)
            {
                x = xk;
                xk = xk - xk / degree + number * Math.Pow(xk, 1 - degree) / degree;
            }
            return x;
        }
    }
}

