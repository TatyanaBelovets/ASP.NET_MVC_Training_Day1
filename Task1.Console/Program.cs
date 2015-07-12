using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Library;

namespace Task1.ConsoleCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            double rootByNewton = MethodsForNumbers.FindRootByNewton(817, 4, 0.001);
            double rootByMath = Math.Pow(817, 0.25);
            Console.WriteLine("{0}, {1}, {2}", rootByMath, rootByNewton, Math.Abs(rootByMath - rootByNewton));
            //Number.FindRootByNewton(-817, 4, 0.001);
            Console.ReadKey();
        }
    }
}
