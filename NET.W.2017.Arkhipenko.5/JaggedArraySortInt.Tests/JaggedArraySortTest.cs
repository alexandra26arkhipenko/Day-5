using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JaggedArraySortInt;

namespace JaggedArraySortInt.Tests
{
    [TestClass]
    public class JaggedArraySortTest
    {
        private bool Comperator(int[][] array1, int[][] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            for (int i = 0; i < array1.Length-1; i++)
            {
                for (int j = 0; j < array1[i].Length-1; j++)
                {
                    if (array1[i][j] == array2[i][j])
                        return true;
                }
            }
            return false;
        }
        [TestMethod]
        public void BubbleSortTest()
        {
            int[][] arrayTest = new int[4][];
            arrayTest[0] = new[] { 10, 20 };
            arrayTest[1] = new[] { 1, 2, 8, 12 };
            arrayTest[2] = new[] { 5, 10, 16 };
            arrayTest[3] = new[] { 18, 1, 5, 6, 8 };
            
           

            int[][] arrayTest1 = new int[4][];
            arrayTest[0] = new[]{ 1, 2, 8, 12 };
            arrayTest[1] = new[] { 10, 20 };
            arrayTest[2] = new[] { 5, 10, 16 };
            arrayTest[3] = new[] { 18, 1, 5, 6, 8 };
            Assert.IsNotNull(JaggedArraySort.BubbleSort(arrayTest, new AscendingSumSort()));
;           
            Assert.IsTrue(Comperator(arrayTest1, JaggedArraySort.BubbleSort(arrayTest, new AscendingSumSort())));
        }
    }
}
