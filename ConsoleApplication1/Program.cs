using System;
using System.Linq;
using Task2.Library;

namespace Task2

{
    class Program
    {
        static void Main(string[] args)
        { 
            var arr = new int[5][];
            {
                arr[0] = new[] { 1, 3, 5, 7, 9 };
                arr[1] = new[] { 0, 2, 4, 6 };
                arr[2] = new[] { 11, 22 };
                arr[3] = new[] { 11, 22, 54, 66 };
                arr[4] = new[] { 11 }; 
            } 

            JaggedArrayMethods.Sort(arr, (a, b) => a.Max() > b.Max() );
            PrintJaggedArray(arr);
            Console.WriteLine("==================");
            JaggedArrayMethods.Sort(arr, (a, b) => a.Min() < b.Min());
            PrintJaggedArray(arr);
            Console.WriteLine("==================");
            JaggedArrayMethods.Sort(arr, (a, b) => a.Sum() > b.Sum());
            PrintJaggedArray(arr);
            Console.WriteLine("==================");
            JaggedArrayMethods.Sort(arr, Multiplication);
            PrintJaggedArray(arr);
            Console.ReadKey();
        }

        public static bool Multiplication(int[] a, int[] b)
        {
            var aMulti = a.Aggregate(1, (current, t) => current*t); //Multiplication of all elements of array
            var bMulti = b.Aggregate(1, (current, t) => current*t);
            return aMulti > bMulti;
        }

        private static void PrintJaggedArray(int[][] arr1)
        {
            foreach (var line in arr1)
            {
                foreach (var number in line)
                {
                    Console.Write("{0} ", number);
                }
                Console.WriteLine();
            }
        }
    }
}
