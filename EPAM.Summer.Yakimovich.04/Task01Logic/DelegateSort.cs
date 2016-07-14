using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01Logic
{
    public static class DelegateSort
    {
        /// <summary>
        /// Method is used for sorting jaggedArray  with delegate as a comparer
        /// </summary>
        /// <param name="array">array</param>
        /// <param name="comparerDelegate">comparer</param>
        public static void SortWithDelegate(int[][] array, ComparerDelegate comparerDelegate)
        {
            if (ReferenceEquals(array, null) || ReferenceEquals(comparerDelegate, null))
                throw new ArgumentNullException();

            IComparer<int[]> comparer = (IComparer<int[]>) comparerDelegate.Target;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) == 1)
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        private static void Swap(ref int[] array1, ref int[] array2)
        {
            int[] temp = array1;
            array1 = array2;
            array2 = temp;
        }
    }
}
