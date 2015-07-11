using System;

namespace Task2.Library
{
    public static class JaggedArrayMethods
    {
        public static void Sort(int[][] array, Func<int[], int[], bool> sortingRule) //sortingRule is a delegate, 
                                                                                     //parametres: <in int[], in int[], out bool>
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
        }

    }
}