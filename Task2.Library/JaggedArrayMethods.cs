using System.Linq;

namespace Task2.Library
{
    public static class JaggedArrayMethods
    {
        public delegate bool SortingRuleDelegate(int[] a, int[] b);

        public static int[][] Sort(int[][] array, SortingRuleDelegate sortingRule)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var nMaxLine = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    nMaxLine = sortingRule(array[nMaxLine], array[j]) ? nMaxLine : j;
                }
                var temp = array[i];
                array[i] = array[nMaxLine];
                array[nMaxLine] = temp;
            }
            return array;
        }

        public static bool MaxElement(int[] a, int[] b)
        {
            return a.Max() > b.Max();
        }

        public static bool MinElement(int[] a, int[] b)
        {
            return a.Min() < b.Min();
        }

        public static bool SumElements(int[] a, int[] b)
        {
            return a.Sum() > b.Sum();
        }

        public static int[][] SortingByMaxElement(int[][] array)
        {
            return Sort(array, MaxElement);
        }        
        
        public static int[][] SortingByMinElement(int[][] array)
        {
            return Sort(array, MinElement);
        }        
        
        public static int[][] SortingBySumElements(int[][] array)
        {
            return Sort(array, SumElements);
        }
    }
}