using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JaggedArraySort;


namespace JaggedArraySort.Tests
{
    [TestClass]
    public class JaggedArraySortTest
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            int colums = 4;
            int[][] arrayTest = new int[colums][];
            arrayTest[0] = new int[] {10, 20};
            arrayTest[1] = new int[] {1, 2, 8, 12};
            arrayTest[2] = new int[] {5, 10, 16};
            arrayTest[3] = new int[] {18, 1, 5, 6, 8};

        }
    }
}
