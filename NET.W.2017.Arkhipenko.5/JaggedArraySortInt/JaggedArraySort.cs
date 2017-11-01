using System;
using System.Linq;

namespace JaggedArraySortInt
{
    public interface IComparer
    {
        int Compare(int[] lhs, int[] rhs);
    }
    public static class JaggedArraySort 
    {       
        public static int[][] BubbleSort(int[][] jaggedArray, IComparer comparer)
        {
            if (jaggedArray == null)
                throw new ArgumentNullException(nameof(jaggedArray));

            if (comparer == null)
                throw new ArgumentNullException(nameof(comparer));
            for (int i = 0; i < jaggedArray.Length; i++)
                if (jaggedArray[i] == null)
                    throw new ArgumentNullException(nameof(jaggedArray), $"{i}th nested array in {nameof(jaggedArray)} is null");
            for (int i = 0; i < jaggedArray.Length-1; i++)
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

        public static void Swap(ref int[] lhs, ref int[] rhs)
        {
            var temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

       
    }

    public class AscendingSumSort : IComparer
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null) return -1;
            if (array1.Length == 0) return -1;

            if (array2 == null) return 1;
            if (array2.Length == 0) return 1;

            if (array1.Sum() > array2.Sum()) return 1;
            if (array1.Sum() == array2.Sum()) return 0;

            return -1;
        }
    }
    public class DecreasingSumSort : IComparer
    {
        public int Compare(int[] array1, int[] array2)
        {

            if (array1 == null) return -1;
            if (array1.Length == 0) return -1;

            if (array2 == null) return 1;
            if (array2.Length == 0) return 1;

            if (array1.Sum() < array2.Sum()) return 1;
            if (array1.Sum() == array2.Sum()) return 0;

            return -1;
        }
    }
    public class AscendingMaxSort : IComparer
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null) return -1;
            if (array1.Length == 0) return -1;

            if (array2 == null) return 1;
            if (array2.Length == 0) return 1;

            if (array1.Max() > array2.Max()) return 1;
            if (array1.Max() == array2.Max()) return 0;

            return -1;
        }
    }
    public class DecreasingMaxSort : IComparer
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null) return -1;
            if (array1.Length == 0) return -1;

            if (array2 == null) return 1;
            if (array2.Length == 0) return 1;

            if (array1.Max() < array2.Max()) return 1;
            if (array1.Max() == array2.Max()) return 0;

            return -1;
        }

        public static implicit operator DecreasingMaxSort(AscendingMaxSort v)
        {
            throw new NotImplementedException();
        }
    }
    public class AscendingMinSort : IComparer
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null) return -1;
            if (array1.Length == 0) return -1;

            if (array2 == null) return 1;
            if (array2.Length == 0) return 1;

            if (array1.Min() > array2.Min()) return 1;
            if (array1.Min() == array2.Min()) return 0;

            return -1;
        }
    }
    public class DecreasingMinSort : IComparer
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null) return -1;
            if (array1.Length == 0) return -1;

            if (array2 == null) return 1;
            if (array2.Length == 0) return 1;

            if (array1.Min() < array2.Min()) return 1;
            if (array1.Min() == array2.Min()) return 0;

            return -1;
        }

    }
}
