using System.Collections.Generic;
using System.Linq;

namespace JaggedArraySortInt.Tests
{
    public class AscendingMinSort : IComparer<int[]>
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
}