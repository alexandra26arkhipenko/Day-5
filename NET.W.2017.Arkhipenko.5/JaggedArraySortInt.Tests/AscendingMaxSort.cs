﻿using System.Collections.Generic;
using System.Linq;
using JaggedArraySortInt;


namespace JaggedArraySortInt.Tests
{
    public class AscendingMaxSort : IComparer<int[]>
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
}