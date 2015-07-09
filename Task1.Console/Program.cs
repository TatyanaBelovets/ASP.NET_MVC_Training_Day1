using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ConsoleCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            double rootByNewton = Task1.Library.Number.FindRootByNewton(9, 2, 0.00001);
            double rootByMath = Math.Pow(9, 0.5);
            Console.WriteLine("{0}, {1}, {2}", rootByMath, rootByNewton, Math.Abs(rootByMath - rootByNewton));
            Console.ReadKey();
        }
    }
}
