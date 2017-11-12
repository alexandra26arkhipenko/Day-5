using System;
using System.Collections;
using System.Collections.Generic;

namespace JaggedArraySort2
{
    public class JaggedArraySort
    {
        #region public
        /// <summary>
        /// Sort is sorting jagged array
        /// </summary>
        /// <param name="jaggedArray"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static int[][] Sort(int[][] jaggedArray, Comparison<int[]> comparer) =>
            BubbleSort(jaggedArray, new Formater(comparer));
        #endregion

        #region private
        private static int[][] BubbleSort(int[][] jaggedArray, IComparer<int[]> comparer)
        {
            if (ReferenceEquals(jaggedArray, null))
                throw new ArgumentNullException(nameof(jaggedArray));

            if (ReferenceEquals(comparer, null))
                throw new ArgumentNullException(nameof(comparer));


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1; j++)
                {
                    if (comparer.Compare(jaggedArray[j], jaggedArray[j + 1]) > 0)
                    {
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
            return jaggedArray;
        }

        /// <summary>
        /// method Swap swaps two rows of an array
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        private static void Swap(ref int[] lhs, ref int[] rhs)
        {
            var temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
#endregion
    }

}
