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
            double rootByNewton = Task1.Library.Number.FindRootByNewton(81, 4, 0.0001);
            double rootByMath = Math.Pow(81, 0.25);
            Console.WriteLine("{0}, {1}, {2}", rootByMath, rootByNewton, Math.Abs(rootByMath - rootByNewton));
            Console.ReadKey();
        }
    }
}
