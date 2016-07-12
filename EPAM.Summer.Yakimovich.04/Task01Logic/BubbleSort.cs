using System;
using System.Collections.Generic;
using System.Linq;

namespace Task01Logic
{
    public static class BubbleSort
    {
        /// <summary>
        /// sorts arraн
        /// </summary>
        /// <param name="arr">array</param>
        /// <param name="comparation">object that implements method of comparison</param>
        public static void BubbleSortMethod(int[][] arr, IComparer<int[]> comparation )
        {
            if (arr == null)
            {
                throw new NullReferenceException();
            }

            if (comparation == null)
            {
                DefaultBubbleSort(arr);
            }
            else
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (comparation.Compare(arr[j], arr[j + 1]) == 1)
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }

        private static void DefaultBubbleSort(int[][] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Sum() > arr[j + 1].Sum())
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
}
