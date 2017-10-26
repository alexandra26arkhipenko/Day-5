using System;
using System.Collections.Generic;
using System.Net;

namespace JaggedArraySort
{
    public class JaggedArraySort
    {
        private static int[] BubbleSortUp(int[] arrayForSort)
        {
            for (int j = 0; j < arrayForSort.Length; j++)
            {
                for (int i = 0; i < arrayForSort.Length - 1; i++)
                {
                    if (arrayForSort[i] > arrayForSort[i + 1])
                    {
                        int temp = arrayForSort[i + 1];
                        arrayForSort[i + 1] = arrayForSort[i];
                        arrayForSort[i] = temp;
                    }

                }
            }
            return arrayForSort;
        }

        private static int[] BubbleSortDown(int[] arrayForSort)
        {
            for (int j = 0; j < arrayForSort.Length; j++)
            {
                for (int i = 0; i < arrayForSort.Length - 1; i++)
                {
                    if (arrayForSort[i] < arrayForSort[i + 1])
                    {
                        int temp = arrayForSort[i + 1];
                        arrayForSort[i + 1] = arrayForSort[i];
                        arrayForSort[i] = temp;
                    }

                }
            }
            return arrayForSort;
        }

        private static int[] FindSum(int[][] jaggedArray, int colums)
        {
            int[] supportArray = new int[colums];

            for (int i = 0; i < colums; i++)
            {
                int sum = 0;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    sum += jaggedArray[i][j];
                }
                supportArray[i] = sum;
            }
            return supportArray;
        }

        public static int[] BubbleSortForJaggedArrayUpSum(int[][] jaggedArray, int colums)
        {
            return BubbleSortUp(FindSum(jaggedArray, colums));
        }

        public static int[] BubbleSortForJaggedArrayDownSum(int[][] jaggedArray, int colums)
        {
            return BubbleSortDown(FindSum(jaggedArray, colums));
        }

        private static int[] FindMax(int[][] jaggedArray, int colums)
        {
            int[] supportArray = new int[colums];

            for (int i = 0; i < colums; i++)
            {
                int max = 0;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] > max)
                    {
                        max = jaggedArray[i][j];
                    }

                }
                supportArray[i] = max;
            }
            return supportArray;
        }

        public static int[] BubbleSortForJaggedArrayUpMax(int[][] jaggedArray, int colums)
        {
            return BubbleSortUp(FindMax(jaggedArray, colums));
        }

        public static int[] BubbleSortForJaggedArrayDownMax(int[][] jaggedArray, int colums)
        {
            return BubbleSortDown(FindMax(jaggedArray, colums));
        }

        private static int[] FindMin(int[][] jaggedArray, int colums)
        {
            int[] supportArray = new int[colums];

            for (int i = 0; i < colums; i++)
            {
                int min = jaggedArray[i][0];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] < min)
                    {
                        min = jaggedArray[i][j];
                    }

                }
                supportArray[i] = min;
            }
            return supportArray;
        }

        public static int[] BubbleSortForJaggedArrayUpMin(int[][] jaggedArray, int colums)
        {
            return BubbleSortUp(FindMin(jaggedArray, colums));
        }

        public static int[] BubbleSortForJaggedArrayDownMin(int[][] jaggedArray, int colums)
        {
            return BubbleSortDown(FindMin(jaggedArray, colums));
        }
    }
}
