using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01Logic
{
    public static class InterfaceSort
    {
        /// <summary>
        /// Method is used for sorting array with interface as a comparer
        /// </summary>
        /// <param name="array">array</param>
        /// <param name="comparer">comparer</param>
        public static void SortWithInterface(int[][] array, IComparer<int[]> comparer)
        {
            if (ReferenceEquals(array, null) || ReferenceEquals(comparer, null))
                throw new ArgumentNullException();

            ComparerDelegate comparerDelegate = comparer.Compare;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparerDelegate(array[j], array[j + 1]) == 1)
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
