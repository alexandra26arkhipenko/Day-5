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
           
            CollectionAssert.AreEqual(JaggedArraySort.BubbleSortForJaggedArrayUpSum(arrayTest, colums), new int[]{23, 30, 31, 38 });
            CollectionAssert.AreEqual(JaggedArraySort.BubbleSortForJaggedArrayDownSum(arrayTest, colums), new int[] { 38, 31, 30, 23 });
            CollectionAssert.AreEqual(JaggedArraySort.BubbleSortForJaggedArrayUpMax(arrayTest, colums), new int[] { 12, 16, 18, 20});
            CollectionAssert.AreEqual(JaggedArraySort.BubbleSortForJaggedArrayDownMax(arrayTest, colums), new int[] { 20, 18, 16, 12 });
            CollectionAssert.AreEqual(JaggedArraySort.BubbleSortForJaggedArrayUpMin(arrayTest, colums), new int[] { 1, 1, 5, 10 });
            CollectionAssert.AreEqual(JaggedArraySort.BubbleSortForJaggedArrayDownMin(arrayTest, colums), new int[] { 10, 5, 1, 1 });

        }
    }
}
