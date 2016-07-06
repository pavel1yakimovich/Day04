using System;
using System.Linq;

namespace Task01Logic
{
    public static class BubbleSort
    {
        /// <summary>
        /// Bubble Sort algorithm with 6 different ways of sorting
        /// </summary>
        /// <param name="arr">array</param>
        /// <param name="criterion">criterion of comparison 1 - sum ascending, 2 - sum descending, 
        /// 3 - max values ascending, 4 - max values descending, 5- min values ascending, 6 - min values descending</param>
        public static void BubbleSortMethod(int[][] arr, int criterion)
        {
            if (arr == null)
            {
                throw new ArgumentException();
            }

            switch (criterion)
            {
                case 1:
                    BubbleSortSumAscend(arr);
                    break;
                case 2:
                    BubbleSortSumDescend(arr);
                    break;
                case 3:
                    BubbleSortMaxAscend(arr);
                    break;
                case 4:
                    BubbleSortMaxDescend(arr);
                    break;
                case 5:
                    BubbleSortMinAscend(arr);
                    break;
                case 6:
                    BubbleSortMinDescend(arr);
                    break;
                default: throw new ArgumentException();
            }
        }

        public static void BubbleSortSumAscend(int[][] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Sum() > arr[j + 1].Sum())
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleSortSumDescend(int[][] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Sum() < arr[j + 1].Sum())
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleSortMaxAscend(int[][] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Max() > arr[j + 1].Max())
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleSortMaxDescend(int[][] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Max() < arr[j + 1].Max())
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleSortMinAscend(int[][] arr)
        {
            for (int i = 0; i < arr.Length ; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Min() > arr[j + 1].Min())
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleSortMinDescend(int[][] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Min() < arr[j + 1].Min())
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
