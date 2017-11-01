using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArraySortInt;

namespace JaggedArraySortInt.Tests
{
    class AscendingSumSort : IComparer
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
}     
